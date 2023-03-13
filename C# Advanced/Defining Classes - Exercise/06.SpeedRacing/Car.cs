using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Car
    {
        private string model;
        private double fuelAmount;
        private double fuelConsumptionPerKm;
        private double traveledDistance;

        public Car()
        {
            this.model = model;
            this.fuelAmount = fuelAmount;
            this.fuelConsumptionPerKm = fuelConsumptionPerKm;
            this.traveledDistance = traveledDistance;
        }

        public string Model { get { return model; } set { model = value; } }
        public double FuelAmount { get { return fuelAmount; } set {fuelAmount = value; } }
        public double FuelConsumptionPerKm { get { return fuelConsumptionPerKm; }set {fuelConsumptionPerKm = value; } }
        public double TraveledDistance { get { return traveledDistance; } set {traveledDistance = value; } }

        public void Drive(double distance)
        {
            if (distance * fuelConsumptionPerKm > fuelAmount)
            {
                Console.WriteLine($"Insufficient fuel for the drive");
            }
            else
            {
                fuelAmount -= distance * fuelConsumptionPerKm;
                traveledDistance += distance;
            }
        }
    }
}
