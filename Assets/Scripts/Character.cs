using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Character : MonoBehaviour
{
    // Base values
    private const int BASE_HEALTH = 100;

    // Stats
    public int speed;
    public int attack;
    public int defense;

    public Slider speedSlider;
    public Slider attackSlider;
    public Slider defenseSlider;

    private int maxHealth;
    private int currentHealth;

    // Start
    public void Start()
    {
        maxHealth = BASE_HEALTH + (defense * 10);
        currentHealth = maxHealth;
    }

    public void Update()
    {
        speed = speedSlider.value;
        attack = attackSlider.value;
        defense = defenseSlider.value;
    }

}
