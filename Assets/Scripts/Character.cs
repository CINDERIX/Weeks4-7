using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    // Base values
    private const int BASE_HEALTH = 100;

    // Stats
    public int speed;
    public int attack;
    public int defense;

    private int maxHealth;
    private int currentHealth;

    // Initialize
    public void Initialize()
    {
        maxHealth = BASE_HEALTH + (defense * 10);
        currentHealth = maxHealth;
    }

    // Attack
    public void Attack(Character opponent)
    {
        opponent.TakeDamage(attack);
    }

    // Take damage directly from attack stat
    public void TakeDamage(int amount)
    {
        currentHealth -= amount;
        currentHealth = Mathf.Max(currentHealth, 0);
        Debug.Log(gameObject.name + " took " + amount + " damage! Health: " + currentHealth);
    }

    // Check if character is still alive
    public bool IsAlive()
    {
        return currentHealth > 0;
    }

    // Get current health
    public int GetHealth()
    {
        return currentHealth;
    }
}
