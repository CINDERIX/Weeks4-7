using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    // UI Elements (Sliders & Text)
    public Slider speedSlider1, attackSlider1, defenseSlider1;
    public Slider speedSlider2, attackSlider2, defenseSlider2;

    public Text speedText1, attackText1, defenseText1;
    public Text speedText2, attackText2, defenseText2;

    public Button fightButton;

    // Characters
    public Character character1;
    public Character character2;

    void Start()
    {
        // Initialize Sliders
        speedSlider1.onValueChanged.AddListener(delegate { UpdateStats(1); });
        attackSlider1.onValueChanged.AddListener(delegate { UpdateStats(1); });
        defenseSlider1.onValueChanged.AddListener(delegate { UpdateStats(1); });

        speedSlider2.onValueChanged.AddListener(delegate { UpdateStats(2); });
        attackSlider2.onValueChanged.AddListener(delegate { UpdateStats(2); });
        defenseSlider2.onValueChanged.AddListener(delegate { UpdateStats(2); });

        // Set button functionality
        fightButton.onClick.AddListener(StartFight);
    }

    void UpdateStats(int characterNumber)
    {
        if (characterNumber == 1)
        {
            character1.speed = (int)speedSlider1.value;
            character1.attack = (int)attackSlider1.value;
            character1.defense = (int)defenseSlider1.value;
            character1.Initialize(); // Update health based on defense

            // Update UI text
            speedText1.text = "Speed: " + character1.speed;
            attackText1.text = "Attack: " + character1.attack;
            defenseText1.text = "Defense: " + character1.defense;
        }
        else
        {
            character2.speed = (int)speedSlider2.value;
            character2.attack = (int)attackSlider2.value;
            character2.defense = (int)defenseSlider2.value;
            character2.Initialize(); // Update health based on defense

            // Update UI text
            speedText2.text = "Speed: " + character2.speed;
            attackText2.text = "Attack: " + character2.attack;
            defenseText2.text = "Defense: " + character2.defense;
        }
    }

    void StartFight()
    {
        Debug.Log("Fight Started!");
        // Call battle logic here
    }
}
