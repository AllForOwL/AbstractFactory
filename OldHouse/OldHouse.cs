using AbstractFactory.Interfaces;

namespace AbstractFactory.OldHouse
{
    public class OldHouse : IHouse
    {
        public void SetWindow(IWindow window)
        {
            System.Console.WriteLine("Set old window to house \n");
        }

        public void SetDoor(IDoor door)
        {
            System.Console.WriteLine("Set old door to house \n");
        }
    }
}
