using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Engine
    {
        //private string engineModel;
        //private int power;
        
        public Engine(string engineModel, int power)
        {
            EngineModel = engineModel;
            Power = power;
        }

        public string EngineModel { get; set; }
        public int Power { get; set; }
        public string Efficiency { get; set; }
        public int Displacement { get; set; }   

        public static Engine GetEngineProperties(string[] engineProperties)
        {
            Engine engine = new(engineProperties[0], int.Parse(engineProperties[1]));

            for (int i = 2; i < engineProperties.Length; i++)
            {
                bool isDigit = int.TryParse(engineProperties[i], out int checker);

                if (isDigit)
                {
                    engine.Displacement = checker;
                }
                else
                {
                    engine.Efficiency = engineProperties[i];
                }
            }
            return engine;
        }

        public override string ToString()
        {
            string displacement = Displacement == 0 ? "n/a" : Displacement.ToString();
            string efficiency = Efficiency ?? "n/a";

            string result = 
                $"{EngineModel}:{Environment.NewLine}" + 
                $"    Power: {Power}{Environment.NewLine}" +
                $"    Displacement: {displacement}{Environment.NewLine}" +
                $"    Efficiency: {efficiency}";

            return result;
        }
    }
}
