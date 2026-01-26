using System.Collections;
using UnityEngine;

public class Damages : Button
{
    private Health health;
    private GameObject Enemy;
    private Dragon dragon;
    protected override void Start()
    {
        base.Start();
        dragon = FindFirstObjectByType<Dragon>();
        health = FindFirstObjectByType<Health>();
    }
    public void Damagess()
    {
        dragon.EnemyBeenHit();
        Enemy = GameObject.Find("Enemy");
        health = Enemy.GetComponent<Health>();
        health.TakeDamage(20f);
        base.Nexturn();
    }
}
