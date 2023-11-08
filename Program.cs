using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trokut
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Unesi prvu stranicu pravokutnog trokuta: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Unesi drugu stranicu pravokutnog trokuta: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.Write("Unesi trecu stranicu pravokutnog trokuta: ");
            int z = Convert.ToInt32(Console.ReadLine());

            if(x<1 || y<1 || z<1){
                Console.WriteLine("Unijeli se pogrešne vrijednosti: " + x + ", " + y + ", " + z);
                Console.ReadKey();
                System.Environment.Exit(1);
            }
            if(x>z && x>y){
                int hipotenuza = (int)(Math.Pow(y, 2) + Math.Pow(z, 2));
                if (Math.Sqrt(hipotenuza) == x)
                {
                    Console.WriteLine("Upisali ste validan pravokutan trokut.");
                }
                else
                {
                    Console.WriteLine("Unesli ste pogrešne vrijednosti za pravokutan trokut.");
                }
            }
            else if (y > x && y>z){
                int hipotenuza = (int)(Math.Pow(x, 2) + Math.Pow(z, 2));
                if (Math.Sqrt(hipotenuza) == y)
                {
                    Console.WriteLine("Upisali ste validan pravokutan trokut.");
                }
                else
                {
                    Console.WriteLine("Unesli ste pogrešne vrijednosti za pravokutan trokut.");
                }
            }
            else
            {
                int hipotenuza = (int)(Math.Pow(y, 2) + Math.Pow(x, 2));
                if (Math.Sqrt(hipotenuza) == z)
                {
                    Console.WriteLine("Upisali ste validan pravokutan trokut.");
                }
                else
                {
                    Console.WriteLine("Unesli ste pogrešne vrijednosti za pravokutan trokut.");
                }
            }
            

            Console.ReadKey();
        }
    }
}
