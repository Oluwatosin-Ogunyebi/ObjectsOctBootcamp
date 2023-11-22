using System;
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

    public float GetHealth()
    {
        return currentHealth;
    }

    public void SetHealth(float value)
    {
        if (value > maxHealth || value < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(value), $"Valid range for health is between 0 and {maxHealth}");
        }

        currentHealth = value;
    }
}
