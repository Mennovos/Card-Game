using UnityEngine;

public class Health : MonoBehaviour
{
    public float currentHealth;
    public float maxHealth = 100f;
    [SerializeField] private UnityEngine.UI.Image healthBar;

    void Update()
    {
        healthBar.fillAmount = currentHealth / maxHealth;
        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
    }
    public void TakeDamage(float damage)
    {
        currentHealth -= damage;
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
