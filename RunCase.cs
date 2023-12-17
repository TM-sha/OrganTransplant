namespace OrganTransplant
{
    internal class RunCase
    {
        public static void RunTheCase()
        {
            Bernt bernt = new Bernt();
            Kåre kåre = new Kåre();

            PrintColoredText("**Bernt's nyre er skadet og han trenger en ny nyre for å overleve!**\n", ConsoleColor.Yellow);
            Thread.Sleep(3000);
            PrintColoredText("Heldigvis er fetteren hans Kåre en match!\n", ConsoleColor.Cyan);
            Thread.Sleep(2500);

            Console.WriteLine("Status på Bernt og Kåre's nyrer:\n");
            Thread.Sleep(2000);

            PrintOrganStatus("Bernt", bernt.nyre, bernt.nyre2, ConsoleColor.Red);
            PrintOrganStatus("Kåre", kåre.nyre, kåre.nyre2, ConsoleColor.Green);
            Thread.Sleep(1000);

            Bernt.BerntHealth(nyre: false, nyre2: false);
            Kåre.KåreHealth(nyre: true, nyre2: true);
            Transplantasjon.ExecuteTransplantation();
            Thread.Sleep(500);

            PrintColoredText("****Hurra! Bernt overlever!****\n", ConsoleColor.Yellow);

            bernt.nyre2 = kåre.nyre2;
            bernt.nyre = false;
            Thread.Sleep(500);
            PrintColoredText("Bernt: Venstre nyre: Fjernet _ Høyre nyre: Fungerende", ConsoleColor.Green);
            //PrintOrganStatus("Bernt", bernt.nyre, bernt.nyre2, ConsoleColor.Green);

            Console.ReadLine();
        }

        private static void PrintColoredText(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ForegroundColor = ConsoleColor.White;
        }

        private static void PrintOrganStatus(string name, bool nyre1Status, bool nyre2Status, ConsoleColor color)
        {
            Console.Write($"{name}: ");
            Console.ForegroundColor = color;

            string nyreTilstand1 = nyre1Status ? "Fungerende" : "Defekt";
            string nyreTilstand2 = nyre2Status ? "Fungerende" : "Defekt";

            Console.WriteLine($"Venstre nyre: {nyreTilstand1} _ Høyre nyre: {nyreTilstand2}");

            Console.ForegroundColor = ConsoleColor.White;
            Thread.Sleep(2000);
        }
    }
}
