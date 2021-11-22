using System;
using System.IO;
using System.Text;
namespace ProjectSagaAlva
{
    class Program
    {
        static void Main(string[] args)
        {
            int antalLåtar = 20;

            string[] Lista = new string[antalLåtar];

            Console.WriteLine($"Välkommen till musiktoppistan! Skirv in {antalLåtar} låtar .");
            string menyVal = " ";

            while(menyVal != "4")
            {
                Console.WriteLine("1. Visa hela topplistan");
                Console.WriteLine("2. Ändra låt");
                Console.WriteLine("3. sök efter ord");
                Console.WriteLine("4. Avsluta");

                switch (menyVal)
                {
                    case "1":
                        break;

                    case "2":
                        break;

                    case "3":
                        break;

                    case "4":
                        Console.WriteLine("Programmet kommer att avslutas...");
                        break;

                    default:
                        Console.WriteLine("Du valde inget giltigt alnternativ");
                        break;


                }
            }





        }
    }
}
