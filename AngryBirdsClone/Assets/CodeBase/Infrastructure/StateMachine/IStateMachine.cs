using Infrastructure.States;

namespace Infrastructure.StateMachine
{
    public interface IStateMachine
    {
        void Enter<TState>() where TState : class, IState;
        IState ChangeState<TState>() where TState : class, IState;
    }
}