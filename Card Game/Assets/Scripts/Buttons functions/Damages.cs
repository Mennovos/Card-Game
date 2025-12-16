using UnityEngine;

public class Damages : Button
{
    [SerializeField] private GameObject enemyHealth;
    private Health health;
    protected override void Start()
    {
        base.Start();
        health = FindFirstObjectByType<Health>();
    }
    public void Damagess()
    {
        enemyHealth.GetComponent<Health>().TakeDamage(20f);
        base.Nexturn();
    }

}
