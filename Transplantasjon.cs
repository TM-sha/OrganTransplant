namespace OrganTransplant
{
    internal class Transplantasjon
    {
        public static void ExecuteTransplantation()
        {
            Console.Write("Tast (3) for å overføre Kåre's friske nyre til Bernt ");
            var input = Convert.ToInt32(Console.ReadLine());

            switch (input)
            {
                case 3:
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Thread.Sleep(3000);
                    Console.WriteLine("Bernt's nyretransplantasjon ble en skussess!\n");
                    break;
            }
            if (input != 3)
            {
                Console.WriteLine("Programmet avsluttes..");
                Environment.Exit(0);
            }
        }
    }
}
