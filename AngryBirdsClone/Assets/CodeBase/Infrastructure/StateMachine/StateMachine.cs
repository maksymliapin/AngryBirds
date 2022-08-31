using Infrastructure.StateFactory;
using Infrastructure.States;
using Zenject;

namespace Infrastructure.StateMachine
{
    public class StateMachine : IStateMachine
    {
        private readonly IStateFactory stateFactory;
        private IState currentState;

        [Inject]
        public StateMachine(IStateFactory stateFactory) =>
            this.stateFactory = stateFactory;

        public void Enter<TState>() where TState : class, IState
        {
            var state = ChangeState<TState>();
            state.Enter();
        }

        public IState ChangeState<TState>() where TState : class, IState
        {
            currentState?.Exit();
            var state = stateFactory.GetState<TState>();
            currentState = state;
            return state;
        }
    }
}