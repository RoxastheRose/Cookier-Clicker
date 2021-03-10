using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerUpUI : MonoBehaviour
{
    public Text costText;
    public Text nameText;
    [SerializeField] public string powerUpName;
    [SerializeField] public PlayerStats stats;

    private void Start()
    {
        nameText.text = powerUpName;
    }

    private void Update()
    {
        int cost = stats.GetCost(powerUpName);
        costText.text = "Chips: " + cost.ToString();
    }
}
