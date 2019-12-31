namespace Cooler.ConsoleTest.NullObjectPattern
{
    public interface IProductService : IService
    {
        string GetProduct(int id);
    }
}