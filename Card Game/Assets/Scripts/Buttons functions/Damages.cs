using UnityEngine;

public class Damages : Button
{
    private Health health;
    void Start()
    {
        health = FindFirstObjectByType<Health>();
    }
    public void Damagess()
    {
        health.TakeDamage(20f);
    }

}
