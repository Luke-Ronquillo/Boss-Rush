using UnityEngine;
namespace lukeRonquillo
{
    public class BossScript : MonoBehaviour
    {
        StateMachine myStateMachine;
        Animator myBossAnim;
        CapsuleCollider myAwakeCollider;
        Transform playerTransform;

        // Animator String Index
        int isAwakeIndex = Animator.StringToHash("isAwake");
        int withinMeleeIndex = Animator.StringToHash("withinMelee");
        private void Start()
        {
            myStateMachine = new StateMachine(this);
            myStateMachine.ChangeState(new BossIdleState(myStateMachine));
            myAwakeCollider = GetComponent<CapsuleCollider>();
            myBossAnim = GetComponentInChildren<Animator>();
        }
        private void Update()
        {
            myStateMachine.Update();
        }
        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.layer == LayerMask.NameToLayer("Player") && !myBossAnim.GetBool(isAwakeIndex)) 
            {
                myBossAnim.SetBool(isAwakeIndex, true);
                playerTransform = other.gameObject.transform;
                myAwakeCollider.enabled = false;
            }
            else if (other.gameObject.layer == LayerMask.NameToLayer("Player"))
            {
                myBossAnim.SetBool(withinMeleeIndex, true);
            }
        }
        private void OnTriggerExit(Collider other)
        {
            if (other.gameObject.layer == LayerMask.NameToLayer("Player"))
            {
                myBossAnim.SetBool(withinMeleeIndex, false);
            }
        }
    }
}
