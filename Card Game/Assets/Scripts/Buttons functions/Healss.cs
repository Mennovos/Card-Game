using UnityEngine;

public class Healss : Button
{
    private Health health;
    private Vector3 Orginelscale;
    protected override void Start()
    {
        Orginelscale = transform.localScale;
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
        Orginelscale = new Vector3(1.3f, 1.3f, 1.3f);
    }
    private void OnMouseExit()
    {
        transform.localScale = Orginelscale;
    }
}
