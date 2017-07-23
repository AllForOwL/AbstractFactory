using System;
using AbstractFactory.Factories;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var modernFactory = new ModernHouseFactory();
            var oldFactory = new OldHouseFactory();

            var modernHouse = modernFactory.CreateHouse();
            var modernWindow = modernFactory.CreateWindow();
            var modernDoor = modernFactory.CreateDoor();

            modernHouse.SetWindow(modernWindow);
            modernHouse.SetDoor(modernDoor);

            var oldHouse = oldFactory.CreateHouse();
            var oldWindow = oldFactory.CreateWindow();
            var oldDoor = oldFactory.CreateDoor();

            oldHouse.SetWindow(oldWindow);
            oldHouse.SetDoor(oldDoor);

            Console.ReadKey();
        }
    }
}