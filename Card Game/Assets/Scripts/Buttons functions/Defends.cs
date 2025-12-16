using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Defends : Button
{
    [SerializeField] private TextMeshProUGUI defendText;
    private float defenceValue = 0f;
    protected override void Start()
    {
        base.Start();
        defendText.text = "Defence:";
    }
    public void Addefence()
    {
        defenceValue += 10f;
        defendText.text = "Defence: " + defenceValue;
        base.Nexturn();
    }
}
