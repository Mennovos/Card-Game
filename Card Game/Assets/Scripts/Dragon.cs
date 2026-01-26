using UnityEngine;

public class Dragon : MonoBehaviour
{
    private Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }
    public void PlayAttackAnimation()
    {
        animator.SetTrigger("EnemyAttacks");
    }
    public void EnemyTakesDamage()
    {
       animator.SetTrigger("EnemyDamage");
    }
    public void EnemyBeenHit()
    {
       animator.SetTrigger("EnemyHit");
    }
    public void EnemyDies()
    {
       animator.SetTrigger("EnemyDie");
    }
}
