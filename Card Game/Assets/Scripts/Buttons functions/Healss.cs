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
        Debug.Log("Healed 30 health points.");
        health.Heal(30f);
        base.Nexturn();
    }
    private void OnMouseOver()
    {
        transform.localScale = new Vector3(1.3f, 1.3f, 1.3f);
    }
    private void OnMouseExit()
    {
        transform.localScale = new Vector3(1f, 1f, 1f);
    }
}
