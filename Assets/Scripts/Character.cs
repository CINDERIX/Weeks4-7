using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Character : MonoBehaviour
{

    // Stats
    public float speed;
    public float attack;
    public float defense;

    public Slider speedSlider;
    public Slider attackSlider;
    public Slider defenseSlider;

    private int maxHealth;
    private int currentHealth;

    // Start
    public void Start()
    {
        currentHealth = maxHealth;
     
    }

    public void Update()
    {
        speed = speedSlider.value;
        attack = attackSlider.value;
        defense = defenseSlider.value;
    }

}
