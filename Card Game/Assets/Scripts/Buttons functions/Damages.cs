using UnityEngine;

public class Damages : Button
{
    private Health health;
    private GameObject Enemy;
    protected override void Start()
    {
        base.Start();
        health = FindFirstObjectByType<Health>();
    }
    public void Damagess()
    {
        Enemy = GameObject.Find("Enemy");
        health = Enemy.GetComponent<Health>();
        health.TakeDamage(20f);
        base.Nexturn();
    }

}
