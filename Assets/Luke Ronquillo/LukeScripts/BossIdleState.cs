using UnityEngine;
namespace lukeRonquillo
{
    public class BossIdleState : State
    {
        public BossIdleState(StateMachine machine) : base(machine)
        {
            this.machine = machine;
        }
        public override void OnEnter()
        {
            base.OnEnter();
        }
        public override void OnUpdate()
        {
            base.OnUpdate();
            Debug.Log("We are Idle");
        }
        public override void OnExit()
        {
            base.OnExit();
        }
    }
}