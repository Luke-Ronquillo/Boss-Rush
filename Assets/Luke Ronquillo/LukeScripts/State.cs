using UnityEngine;
namespace lukeRonquillo
{
    public class State
    {
        public StateMachine machine;
        public float elapsedTime;
        public State (StateMachine machine)
        {
            this.machine = machine;
        }
        public virtual void OnEnter()
        {
            Debug.Log("Entered state");
        }
        public virtual void OnUpdate()
        {
            elapsedTime += Time.deltaTime;
        }
        public virtual void OnExit()
        {
            Debug.Log("Exited state");

        }
    }
}