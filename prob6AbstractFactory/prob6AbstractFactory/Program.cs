/*
Design a car manufacturing system where different factories produce ElectricCarParts and DieselCarParts,
like engines and fuel systems.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace prob6AbstractFactory
{
    public interface IEngine
    {
        string GetEngineType();
    }

    public interface IFuelSystem
    {
        string GetFuelSystemType();
    }

    public interface ICarPartsFactory
    {
        IEngine CreateEngine();
        IFuelSystem CreateFuelSystem();
    }

    public class ElectricEngine : IEngine
    {
        public string GetEngineType()
        {
            return "Electric Engine"; 
        }
    }

    public class ElectricFuelSystem : IFuelSystem
    {
        public string GetFuelSystemType()
        {
            return "FuelSystem battery";
        }
    }

    public class DieselEngine : IEngine
    {
        public string GetEngineType()
        {
            return "Diesel Engine";
        }
    }

    public class DieselFuelSystem : IFuelSystem
    {
        public string GetFuelSystemType()
        {
            return "Diesel FuelSystem battery";
        }
    }

    public class ElectricCarPartsFactory : ICarPartsFactory
    {
        public IEngine CreateEngine() => new ElectricEngine();
        public IFuelSystem CreateFuelSystem() => new ElectricFuelSystem();
    }

    public class DieselCarPartsFactory : ICarPartsFactory
    {
        public IEngine CreateEngine() => new DieselEngine();
        public IFuelSystem CreateFuelSystem() => new DieselFuelSystem();
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            ICarPartsFactory partEl = new ElectricCarPartsFactory();
            var partEngEl = partEl.CreateEngine();
            var partFuelEl = partEl.CreateFuelSystem();

            Console.WriteLine($"Engine: {partEngEl.GetEngineType()}");
            Console.WriteLine($"Fuel System: {partFuelEl.GetFuelSystemType()}");

            ICarPartsFactory partDies = new DieselCarPartsFactory();
            var partEngDies = partDies.CreateEngine();
            var partFuelDies = partDies.CreateFuelSystem();

            Console.WriteLine($"Engine: {partEngDies.GetEngineType()}");
            Console.WriteLine($"Fuel System: {partFuelDies.GetFuelSystemType()}");
        }
    }
}
