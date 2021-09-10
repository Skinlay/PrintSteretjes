using System;

namespace SteretjesPrinten
{
    class Program
    {
        static void Main(string[] args)
        {
            string sSter = "*";
            //telt het aantal karakters in de string
            int iAantal = sSter.Length;
            //laat de gebruiker een getal in vullen
            int userInput = Convert.ToInt32(Console.ReadLine());

            // zolang het aantal kleiner is dan wat de gebruiker wil
            while (iAantal < userInput)
            {
                //schrijft sSter uit naar de consol
                Console.WriteLine(sSter);
                //voeg sSter samen met * 
                // de string word steeds een * langer
                sSter = sSter + "*";
                // telt het aantal karakters opnieuw omdat er net een nieuwe is toegevoed
                iAantal = sSter.Length;
            }
            // haalt een * weg 
            // anders staat het maximalen aantal er twee keer 
            sSter = sSter.Remove(sSter.Length - 1);

            //zolang het aantal karakter in sSter langer is dan 1
            while (iAantal > 1)
            {
                // haalt een * weg 
                sSter = sSter.Remove(sSter.Length - 1);
                //schrijf sSter uit naar de consol
                Console.WriteLine(sSter);
                // telt het aantal karakters opnieuw omdat er net een verwijdert is
                iAantal = sSter.Length;
            }

        }
    }
}
