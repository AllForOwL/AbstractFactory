using AbstractFactory.Interfaces;
using AbstractFactory.ModernHouse;

namespace AbstractFactory.Factories
{
    public class ModernHouseFactory : IAbstractHouseFactory
    {
        public IHouse CreateHouse()
        {
            System.Console.WriteLine("Create modern house \n");
            return new ModernHouse.ModernHouse();
        }

        public IWindow CreateWindow()
        {
            System.Console.WriteLine("Create modern window \n");
            return new ModernWindow();
        }

        public IDoor CreateDoor()
        {
            System.Console.WriteLine("Create modern door \n");
            return new ModernDoor();
        }
    }
}
