namespace AbstractFactory.Interfaces
{
    public interface IAbstractHouseFactory
    {
        IHouse CreateHouse();
        IWindow CreateWindow();
        IDoor CreateDoor();
    }
}