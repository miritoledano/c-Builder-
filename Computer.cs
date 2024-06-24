using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulder
{
    internal  class Computer
    {
        public string SerialNumber { get; set; }
        public string ModelName { get; set; }
        public string ProcessorModel { get; set; }
        public int MemorySize { get; set; }
        public DiskType DiskType { get; set; }

        public override string ToString()
        {
            return $"Serial Number: {SerialNumber}, Model Name: {ModelName}, Processor Model: {ProcessorModel}, Memory Size: {MemorySize}, Disk Type: {DiskType}";
        }
       
    }

    public enum DiskType
    {
        SSD,
        Normal
    }
    
    internal class DesktopComputer : Computer
    {
        public string FormFactor { get; set; }

        public override string ToString()
        {
            return base.ToString() + $", Form Factor: {FormFactor}";
        }
    }
    internal class Tablet : Computer
    {
        public bool HasStylus { get; set; }

        public override string ToString()
        {
            return base.ToString() + $", Stylus: {HasStylus}";
        }
    }
    internal class FileServer : Computer
    {
        public int StorageCapacity { get; set; }

        public override string ToString()
        {
            return base.ToString() + $", Storage Capacity: {StorageCapacity}";
        }
    }

   
    }
    
