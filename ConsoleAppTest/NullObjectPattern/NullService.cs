namespace ConsoleAppTest.NullObjectPattern
{
    public class NullService : IService
    {
        public bool IsNullObject => true;

        public static IService Instance => new NullService();
    }
}