using AbstractFactory.Interfaces;
using AbstractFactory.OldHouse;

namespace AbstractFactory.Factories
{
    public class OldHouseFactory : IAbstractHouseFactory
    {
        public IHouse CreateHouse()
        {
            System.Console.WriteLine("Create old house \n");
            return new OldHouse.OldHouse();
        }

        public IWindow CreateWindow()
        {
            System.Console.WriteLine("Create old window \n");
            return new OldWindow();
        }

        public IDoor CreateDoor()
        {
            System.Console.WriteLine("Create old door \n");
            return new OldDoor();
        }
    }
}
