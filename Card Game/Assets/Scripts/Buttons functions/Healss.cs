using UnityEngine;

public class Healss : Button
{
    private GameObject Player;
    private Health health;
    
    protected override void Start()
    {
        base.Start();
        Player = GameObject.Find("Player");
        health = Player.GetComponent<Health>();
    }
    public void Healllls()
    {
        Debug.Log("Healed 30 health points.");
        base.Nexturn();
    }
}
