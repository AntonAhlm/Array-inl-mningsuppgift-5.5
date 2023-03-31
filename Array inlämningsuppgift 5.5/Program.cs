using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] MagicSvar = { "Nej", "Ja", "Kanske", "Oklart", "Vet inte", "Absolut Inte!", "JAAA!!!", "Mycket Möjligt", "Tveksamt", "Fråga någon annan" };
            string Svar = "";
            Random Slump = new Random();

            Console.WriteLine("Ställ en fråga : ");
            Console.ReadLine();


            while (Svar!="a")
            {
                
                Console.WriteLine("Magic 8-ball tänker..");
                Thread.Sleep(500);
                Console.WriteLine("Svar : " + MagicSvar[Slump.Next(0,10)]);
                Thread.Sleep(500);
                Console.WriteLine("Ställ en fråga, eller skriv \"a\" för att avsluta : ");
                Svar = Console.ReadLine();
            }

            
            

        }
    }
}
