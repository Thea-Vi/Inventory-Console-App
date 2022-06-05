namespace Inheritance_Interface_MiniProject
{
    public interface IRentable : IInventoryItem
    {
        void Rent();
        void ReturnRental();
    }
}