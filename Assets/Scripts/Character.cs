using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Character : MonoBehaviour
{
    public GameObject charHealthBar;
    public GameObject enemyHealthBar;

    // Stats
    public float speed;
    public float attack;
    public float defense;

    private float timer = 0.0f;
    private float maxTime = 2.0f;

    public Slider speedSlider;
    public Slider attackSlider;
    public Slider defenseSlider;
    public Slider charHealth;
    public Slider enemyHealth;

    private bool fight = false;

    private float currentHealth;

    // Start
    public void Start()
    {
        currentHealth = 10+defense;
        charHealth.maxValue = currentHealth;
    }

    public void Update()
    {
        if (fight)
        {
            timer += Time.deltaTime;
            if (timer >= maxTime/speed)
            {
                timer = 0.0f;
                Attack();
            }
        }


    }

    public void Attack()
    {
        enemyHealth.value -= attack;
    }

    public void Fight()
    {
        fight = true;
//        charHealthBar.SetActive(true);
  //      enemyHealthBar.SetActive(true);
        speed = speedSlider.value;
        attack = attackSlider.value;
        defense = defenseSlider.value;
    }
}
