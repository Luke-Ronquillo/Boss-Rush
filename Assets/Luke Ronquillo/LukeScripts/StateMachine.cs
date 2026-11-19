using Unity.VisualScripting;
using UnityEngine;
namespace lukeRonquillo
{
    public class StateMachine
    {
        State currentState;
        BossScript boss;
        public StateMachine(BossScript boss)
        {
            this.boss = boss;
        }
        public void Update()
        {
            currentState.OnUpdate();
        }
        public void ChangeState(State newState)
        {
            if (currentState != null)
                currentState.OnExit();

            currentState = newState;

            currentState.OnEnter();
        }
    }
}

