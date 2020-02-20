namespace Balances
{
    public interface IDataProvider<T>
    {
        T GetData();
    }
}
