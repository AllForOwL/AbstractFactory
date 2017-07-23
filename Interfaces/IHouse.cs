using AbstractFactory.Interfaces;

namespace AbstractFactory.Interfaces
{
    public interface IHouse
    {
        void SetWindow(IWindow window);
        void SetDoor(IDoor door);
    }
}
