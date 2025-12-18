using System.Collections;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float targetHealth = 100; 
    public float fadeSpeed = 2.0f; 
    public float currentHealth = 100f;
    public float maxHealth = 100f;
    [SerializeField] private UnityEngine.UI.Image healthBar;

    void Update()
    {
        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
        targetHealth = Mathf.Lerp(targetHealth,currentHealth, Time.deltaTime * fadeSpeed);
        healthBar.fillAmount = targetHealth / maxHealth;
    }
    public void TakeDamage(float damage)
    {
        currentHealth -= damage;
        targetHealth = currentHealth;
        if (currentHealth <= 0)
        {
            Die();
        }
    }
    public void Heal(float healAmount)
    {
        currentHealth += healAmount;
    }
    private void Die()
    {
        Debug.Log("Character has died.");
        // Add death logic here (e.g., play animation, disable character, etc.)
    }
}
