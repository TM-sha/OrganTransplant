namespace OrganTransplant
{
    internal class Bernt
    {
        public bool nyre = false;
        public bool nyre2 = false;

        public static void BerntHealth(bool nyre, bool nyre2)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Tast (1) for å fjerne de skadde nyrene til Bernt ");
            var input = Convert.ToInt32(Console.ReadLine());


            switch (input)
            {
                case 1:
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("De skadde nyrene til Bernt er fjernet..\n");
                    Thread.Sleep(2500);
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }
            if (input != 1)
            {
                Console.WriteLine("Programmet avsluttes..");
                Environment.Exit(0);
            }
        }
    }
}
