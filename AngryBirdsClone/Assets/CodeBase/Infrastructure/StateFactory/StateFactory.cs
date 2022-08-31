using System;
using System.Collections.Generic;
using Infrastructure.States;
using Zenject;

namespace Infrastructure.StateFactory
{
    public class StateFactory : IStateFactory
    {
        private readonly Dictionary<Type, IState> states;

        [Inject]
        public StateFactory([Inject(Id = "InitializeState")] IState initializeState)
        {
            states = new Dictionary<Type, IState>()
            {
                [typeof(InitializeState)] = initializeState
            };
        }

        public TState GetState<TState>() => 
            (TState) states[typeof(TState)];
    }
}