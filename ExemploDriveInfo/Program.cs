using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploDriveInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            //DriveInfo classe que retorna informações dos drives instalados na maquina
            //retorna inclusive drives virtuais
            //pen drives
            DriveInfo[] drives = DriveInfo.GetDrives();
            Console.WriteLine("Lista de drives deste computador");
            foreach (DriveInfo drive in drives)
            {
                Console.WriteLine("Nome: " + drive.Name);
                if (!drive.IsReady) continue;
                Console.WriteLine("Volume Label: " + drive.VolumeLabel);
                Console.WriteLine("Total Size: " + drive.TotalSize);
                Console.WriteLine("Free Space: " + drive.TotalFreeSpace);
                Console.WriteLine("Available Space: "+drive.AvailableFreeSpace);
                Console.WriteLine("Is Ready: " + drive.IsReady);
                Console.WriteLine("Drive Type: " + drive.DriveType);
                Console.WriteLine("Drive Format: " + drive.DriveFormat);
                Console.WriteLine("Root: "+ drive.RootDirectory);
                Console.WriteLine("****************************************");
            }

            Console.ReadKey();

        }
    }
}
