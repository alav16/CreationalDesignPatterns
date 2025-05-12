/*
Create a system for building customized Computer objects where users can choose
CPU, RAM, storage, and GPU step by step. 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob9Builder
{
    public class Computer
    {
        public string CPU { get; set; }
        public string Ram { get; set; }
        public string Storage { get; set; }
        public string GPU { get; set; }

        public void Show()
        {
            if (CPU != null) Console.WriteLine(CPU);
            if (Ram != null) Console.WriteLine(Ram);
            if (Storage != null) Console.WriteLine(Storage);
            if (GPU != null) Console.WriteLine(GPU);
        }
    }

    public class ComputerBuilder
    {
        private Computer _computer = new Computer();

        public ComputerBuilder SetCPU(string cpu)
        {
            _computer.CPU = cpu;
            return this;
        }

        public ComputerBuilder SetRam(string ram)
        {
            _computer.Ram = ram;
            return this;
        }

        public ComputerBuilder SetStorage(string storage)
        {
            _computer.Storage = storage;
            return this;
        }

        public ComputerBuilder SetGPU(string gpu)
        {
            _computer.GPU = gpu;
            return this;
        }

        public Computer Build()
        {
            return _computer;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var gaming = new ComputerBuilder()
                    .SetCPU("Intel")
                    .SetRam("32Gb")
                    .SetStorage("1Tb")
                    .SetGPU("4000")
                    .Build();

            gaming.Show();

        }
    }
}
