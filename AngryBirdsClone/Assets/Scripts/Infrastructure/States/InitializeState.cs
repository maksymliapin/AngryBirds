using UnityEngine;

namespace Infrastructure.States
{
    public class InitializeState: IState
    {
        public void Enter()
        {
            Debug.Log("Yes");
        }

        public void Exit()
        {
            
        }
    }
}