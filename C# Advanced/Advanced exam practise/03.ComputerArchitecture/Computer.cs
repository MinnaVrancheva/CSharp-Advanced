using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerArchitecture
{
    public class Computer
    {
        public Computer(string model, int capacity)
        {
            Model = model;
            Capacity = capacity;
            Multiprocessor = new List<CPU>();
        }

        public string Model { get; set; }
        public int Capacity { get; set; }
        public List<CPU> Multiprocessor { get; set; }
        public int Count => Multiprocessor.Count;

        public void Add(CPU cpu)
        {
            if (Multiprocessor.Count < Capacity)
            {
                Multiprocessor.Add(cpu);
            }
        }

        public bool Remove(string brand)
        {
            if (Multiprocessor.Where(cpu => cpu.Brand == brand).Any())
            {
                Multiprocessor.RemoveAll(cpu => cpu.Brand == brand);
                return true;
            }
            else
            {
                return false;
            }
        }

        public CPU MostPowerful()
        {
            return Multiprocessor.MaxBy(x => x.Frequency);
        }

        public CPU GetCPU(string brand)
        {
            if (!Multiprocessor.Any(cpu => cpu.Brand == brand))
            {
                return null;
            }

            return Multiprocessor.FirstOrDefault(cpu => cpu.Brand == brand);
        }

        public string Report()
        {
            StringBuilder listReport = new StringBuilder();

            listReport.AppendLine($"CPUs in the Computer {this.Model}:");

            foreach (CPU cpu in this.Multiprocessor)
            {
                listReport.AppendLine(cpu.ToString());
            }

            return listReport.ToString().TrimEnd();
        }
    }
}
