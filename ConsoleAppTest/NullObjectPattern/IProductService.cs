namespace ConsoleAppTest.NullObjectPattern
{
    public interface IProductService : IService
    {
         string GetProduct(int id);
    }
}