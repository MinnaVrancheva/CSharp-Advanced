using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturer
{
    public class Car
    {
        private string make;
        private string model;
        private int year;
        private double fuelQuantity;
        private double fuelConsumption;
        private int engineIndex;
        private int tiresIndex;
        private int horsePower;
        public double pressure;

        //public Car()
        //{
        //    Make = "VW";
        //    Model = "Golf";
        //    Year = 2025;
        //    FuelQuantity = 200;
        //    FuelConsumption = 10;
        //}

        //public Car(string make, string model, int year)
        //{
        //    this.Make = make;
        //    this.Model = model;
        //    this.Year = year;
        //}

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption, int engineIndex, int tiresIndex, int horsePower, double pressure)
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
            this.EngineIndex = engineIndex;
            this.TiresIndex = tiresIndex;
            this.HorsePower = horsePower;
            this.Pressure = pressure;
        }
        //public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption, int engineIndex, int tiresIndex, int horsePower, double pressure) : this(make, model, year, fuelQuantity, fuelConsumption)
        //{
        //    EngineIndex = engineIndex;
        //    TiresIndex = tiresIndex;
        //    HorsePower = horsePower;
        //    Pressure = pressure;
        //}

        //public Engine Engine { get { return engine; } set { engine = value; } }
        //public Tire[] Tires { get { return tires; } set { tires = value; } }
        public string Make { get { return make; } set { make = value; } }
        public string Model { get { return model; } set { model = value; } }
        public int Year { get { return year; } set { year = value; } }
        public double FuelQuantity { get { return fuelQuantity; } set { fuelQuantity = value; } }
        public double FuelConsumption { get { return fuelConsumption; } set { fuelConsumption = value; } }
        public int EngineIndex { get { return engineIndex; } set { engineIndex = value; } }
        public int TiresIndex { get { return tiresIndex; } set { tiresIndex = value; } }
        public int HorsePower { get { return horsePower; } set { horsePower = value; } }
        public double Pressure { get { return pressure; } set { pressure = value; } }

        public double Drive(double fuelQuantity, double fuelConsumption)
        {
            fuelQuantity -= fuelConsumption / 100 * 20;
            return fuelQuantity;
        }
    }
}
