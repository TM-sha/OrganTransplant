namespace OrganTransplant
{
    internal class Kåre
    {
        public bool nyre = true;
        public bool nyre2 = true;

        public static void KåreHealth(bool nyre, bool nyre2)
        {
            Console.Write("Tast (2) for å fjerne den ene friske nyren til Kåre ");
            var input = Convert.ToInt32(Console.ReadLine());

            switch (input)
            {
                case 2:
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Den ene friske nyren til Kåre er fjernet..\n");
                    Thread.Sleep(2500);
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }
            if (input != 2)
            {
                Console.WriteLine("Programmet avsluttes..");
                Environment.Exit(0);
            }
        }
    }
}
