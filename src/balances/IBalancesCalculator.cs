namespace Balances
{
    public interface IBalancesCalculator<TInput, TOutput>
    {
        TOutput Calculate(TInput input);
    }
}
