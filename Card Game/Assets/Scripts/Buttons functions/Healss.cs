using UnityEngine;

public class Healss : Button
{
    private GameObject Player;
    private Health health;
    
    protected override void Start()
    {
        base.Start();
    }
    public void Healllls()
    {
        Player = GameObject.Find("Player");
        health = Player.GetComponent<Health>();
        health.Heal(20f);
        base.Nexturn();
    }
}
