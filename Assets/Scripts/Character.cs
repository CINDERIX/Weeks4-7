using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Character : MonoBehaviour
{

    //Game Objects
    public GameObject hitsplat;

    // Stats
    public float speed;
    public float attack;
    public float defense;

    // timers
    private float timer = 0.0f;
    private float maxTime = 2.0f;

    public Slider speedSlider;
    public Slider attackSlider;
    public Slider defenseSlider;
    public Slider charHealth;

    public Slider enemyHealth;
    public GameObject enemy;

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

        Collider2D enemyCollider = enemy.GetComponent<Collider2D>();

        //https://docs.unity3d.com/6000.0/Documentation/ScriptReference/Collider2D-bounds.html
        Vector2 randomPosition = new Vector2(Random.Range(enemyCollider.bounds.min.x, enemyCollider.bounds.max.x), Random.Range(enemyCollider.bounds.min.y, enemyCollider.bounds.max.y));
        GameObject hitsplatPrefab = Instantiate(hitsplat, randomPosition, Quaternion.identity);
        Destroy(hitsplatPrefab, 0.3f);
    }

    public void Fight()
    {
        fight = true;
        speed = speedSlider.value;
        attack = attackSlider.value;
        defense = defenseSlider.value;
    }

}
