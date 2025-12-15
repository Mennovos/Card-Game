using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Defends : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI defendText;
    private float defenceValue = 0f;
    void Start()
    {
        defendText.text = "Defence:";
    }
    private void Addefence()
    {
        Debug.Log("Defence increased.");
        defendText.text = "Defence: " + defenceValue.ToString();
        // Add logic to increase defence in the game
    }
}
