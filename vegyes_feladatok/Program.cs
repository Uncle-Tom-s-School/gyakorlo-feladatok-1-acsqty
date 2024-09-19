namespace vegyes_feladatok
{
    internal class Program
    {
        static void feladat1()
        {
            Console.WriteLine("Add meg az értékelések számát!: ");
            int osszesert = int.Parse(Console.ReadLine());

            Console.WriteLine("Add meg a pozítív értékelések számát!: ");
            int pozitiv = int.Parse(Console.ReadLine());

            double szazalek = pozitiv % osszesert;
            szazalek = Math.Round(szazalek, 0);

            string rating;
            ConsoleColor color;

            if (szazalek >= 90)
            {
                rating = "Nagyon pozitív";
                color = ConsoleColor.Green;
            }
            else if (szazalek >= 75)
            {
                rating = "pozitív";
                color = ConsoleColor.Green;
            }
            else if (szazalek >= 55)
            {
                rating = "Többnyire pozitív";
                color = ConsoleColor.Green;
            }
            else if (szazalek >= 45)
            {
                rating = "Vegyes";
                color = ConsoleColor.Yellow;
            }
            else if (szazalek >= 25)
            {
                rating = "Többnyire negatív";
                color = ConsoleColor.Red;
            }
            else if (szazalek >= 10)
            {
                rating = "negatív";
                color = ConsoleColor.Red;
            }
            else
            {
                rating = "Nagyon negatív";
                color = ConsoleColor.Red;
            }
            Console.ForegroundColor = color;
            Console.WriteLine($"Az értékelés: {rating} {szazalek}%)");
            Console.ResetColor();
        }
    

   
        static void feladat2() { }
        

        static void feladat3() { }

        static void feladat4() { }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            feladat1();
        }
    }
}
