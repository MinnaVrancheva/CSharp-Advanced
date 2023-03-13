using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerArchitecture
{
    public class CPU
    {
        public CPU (string brand, int cores, double frequency)
        {
            this.Brand = brand;
            this.Cores = cores;
            this.Frequency = frequency;
        }

        public string Brand { get; set; }
        public int Cores { get; set; }
        public double Frequency { get; set; }

        public override string ToString()
        {
            return 
                $"{Brand} CPU:{Environment.NewLine}" +
                $"Cores: {Cores}{Environment.NewLine}" +
                $"Frequency: {Frequency:f1} GHz";
        }
    }
}
