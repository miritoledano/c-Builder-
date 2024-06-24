using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulder
{
    internal class Program
    {
        static void Main(string[] args)
        {

            TabletBuilder tabletBuilder = new TabletBuilder();
            Tablet tablet = (Tablet)tabletBuilder
                .GenerateSerialNumber()
                .SetModelName("TabletModel")
                .SetProcessorModel("Snapdragon")
                .SetMemorySize(256)
                .SetDiskType(DiskType.SSD)
                .Build();

            DesktopComputerBuilder desktopBuilder = new DesktopComputerBuilder();
            DesktopComputer desktop = (DesktopComputer)desktopBuilder
                .GenerateSerialNumber()
                .SetModelName("DesktopModel")
                .SetProcessorModel("AMD Ryzen")
                .SetMemorySize(1024)
                .SetDiskType(DiskType.Normal)
                .Build();

            FileServerBuilder fileServerBuilder = new FileServerBuilder();
            FileServer fileServer = (FileServer)fileServerBuilder
                .GenerateSerialNumber()
                .SetModelName("FileServerModel")
                .SetProcessorModel("Xeon")
                .SetMemorySize(2048)
                .SetDiskType(DiskType.SSD)
                .Build();

            Console.WriteLine(tablet);
            Console.WriteLine(desktop);
            Console.WriteLine(fileServer);
        }
    }




}
