using UnityEngine;

public class Healss : Button
{
    private Health health;
    void Start()
    {
        health = FindFirstObjectByType<Health>();
    }
    public void Healllls()
    {
        health.Heal(20f);
    }

}
