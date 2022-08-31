using Infrastructure.StateMachine;
using Infrastructure.States;
using Zenject;

namespace Infrastructure
{
    public class Bootstrap
    {
        [Inject]
        public Bootstrap(IStateMachine stateMachine) => 
            stateMachine.Enter<InitializeState>();
    }
}