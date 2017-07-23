using AbstractFactory.Interfaces;

namespace AbstractFactory.ModernHouse
{
    public class ModernHouse : IHouse
    {
        public void SetWindow(IWindow window)
        {
            System.Console.WriteLine("Set modern window to house \n");
        }

        public void SetDoor(IDoor door)
        {
            System.Console.WriteLine("Set modern door to house \n");
        }
    }
}