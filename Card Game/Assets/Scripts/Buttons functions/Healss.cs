using UnityEngine;

public class Healss : Button
{
    private Health health;
    protected override void Start()
    {
        base.Start();
        health = FindFirstObjectByType<Health>();
    }
    public void Healllls()
    {
        health.Heal(30f);
        base.Nexturn();
    }

}
