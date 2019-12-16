namespace ConsoleAppTest.NullObjectPattern
{
    public class ProductService : IProductService
    {
        public bool IsNullObject => false;

        public string GetProduct(int id)
        {
            return "Project:" + id;
        }
    }
}