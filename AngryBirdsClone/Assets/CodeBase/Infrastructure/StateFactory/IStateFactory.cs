namespace Infrastructure.StateFactory
{
    public interface IStateFactory
    {
        TState GetState<TState>();
    }
}