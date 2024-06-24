using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulder
{
    internal abstract class ComputerBuilder
    {
        protected Computer computer;

        public ComputerBuilder()
        {
            computer = new Computer();
        }

        public virtual ComputerBuilder GenerateSerialNumber()
        {
            // Generate serial number logic here
            computer.SerialNumber = "12345";
            return this;
        }

        public virtual ComputerBuilder SetModelName(string modelName)
        {
            computer.ModelName = modelName;
            return this;
        }

        public virtual ComputerBuilder SetProcessorModel(string processorModel)
        {
            computer.ProcessorModel = processorModel;
            return this;
        }

        public virtual ComputerBuilder SetMemorySize(int memorySize)
        {
            // Round the memory size to the nearest available value (256, 512, 1024)
            if (memorySize <= 256)
            {
                computer.MemorySize = 256;
            }
            else if (memorySize <= 512)
            {
                computer.MemorySize = 512;
            }
            else
            {
                computer.MemorySize = 1024;
            }
            return this;
        }

        public virtual ComputerBuilder SetDiskType(DiskType diskType)
        {
            computer.DiskType = diskType;
            return this;
        }

        public virtual Computer Build()

        {

           return computer;
        }

    }
    internal class FileServerBuilder : ComputerBuilder
    {
        public FileServerBuilder()
        {
            computer = new FileServer();
        }
        
    }
    internal class DesktopComputerBuilder : ComputerBuilder
    {
        public DesktopComputerBuilder()
        {
            computer = new DesktopComputer();
        }

       
      


    }
    internal class TabletBuilder : ComputerBuilder
    {
        public TabletBuilder()
        {
            computer = new Tablet();
        }

       


    }
}