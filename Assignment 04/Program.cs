namespace Assignment_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Quebecois");

            QuebecoisHouseBuilder quebecoisHouseBuilder = new QuebecoisHouseBuilder();
            HouseEngineer houseEngineer = new HouseEngineer(quebecoisHouseBuilder);
            houseEngineer.ConstructHouse();
            houseEngineer.GetHouse().displayHouse();
            Console.WriteLine("");

            QuebecoisDuplexBuilder quebecoisDuplexBuilder = new QuebecoisDuplexBuilder();
            DuplexEngineer duplexEngineer = new DuplexEngineer(quebecoisDuplexBuilder);
            duplexEngineer.ConstructDuplex();
            duplexEngineer.GetDuplex().displayDuplex();
            Console.WriteLine("");
            Console.WriteLine("");


            Console.WriteLine("Persian");

            PersianHouseBuilder persianHouseBuilder = new PersianHouseBuilder();
            houseEngineer = new HouseEngineer(persianHouseBuilder);
            houseEngineer.ConstructHouse();
            houseEngineer.GetHouse().displayHouse();
            Console.WriteLine("");

            PersianDuplexBuilder persianDuplexBuilder = new PersianDuplexBuilder();
            duplexEngineer = new DuplexEngineer(persianDuplexBuilder);
            duplexEngineer.ConstructDuplex();
            duplexEngineer.GetDuplex().displayDuplex();
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Modern");
            ModernHouseBuilder modernHouseBuilder = new ModernHouseBuilder();
            houseEngineer = new HouseEngineer(modernHouseBuilder);
            houseEngineer.ConstructHouse();
            houseEngineer.GetHouse().displayHouse();
            Console.WriteLine("");

            ModernDuplexBuilder modernDuplexBuilder = new ModernDuplexBuilder();
            duplexEngineer = new DuplexEngineer(modernDuplexBuilder);
            duplexEngineer.ConstructDuplex();
            duplexEngineer.GetDuplex().displayDuplex();
            Console.WriteLine("");
        }
    }
}
