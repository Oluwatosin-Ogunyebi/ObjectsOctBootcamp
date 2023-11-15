using UnityEngine;

public class Health
{
    private float currentHealth;
    private float maxHealth;
    private float healthRegenRate;


    public Health()
    {

    }

    public Health(float _currentHealth, float _maxHealth, float _healthRegenRate)
    {
        currentHealth = _currentHealth;
        maxHealth = _maxHealth;
        healthRegenRate = _healthRegenRate;
    }

    public Health(float _maxHealth)
    {
        maxHealth = _maxHealth;
    }

    public void AddHealth(float valueToAdd)
    {
        currentHealth += valueToAdd;
    }

    public void DeductHealth(float valueToDeduct)
    {
        currentHealth -= valueToDeduct;
    }
}
