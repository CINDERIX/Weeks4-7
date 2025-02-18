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
    public gameObject enemy;

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

        Collider2D enemyCollider = enemy.GetComponentInParent<Collider2D>();

        Vector2 randomPosition = getEnemyCollider(enemycollider);
        GameObject hitsplatPrefab = Instantiate(hitsplat, randomPosition, Quaternion.identity);
        Destroy(hitsplatPrefab, 0.2f);
    }

    public void Fight()
    {
        fight = true;
        speed = speedSlider.value;
        attack = attackSlider.value;
        defense = defenseSlider.value;
    }

    private Vector2 getEnemyCollider(Collider2D enemyCollider)
    {
        Vector2 randomPosition = new Vector2(Random.Range(enemyCollider.bounds.min.x, enemyCollider.bounds.max.x), Random.Range(enemyCollider.bounds.min.y, enemyCollider.bounds.max.y));
        return randomPosition;
    }
}
