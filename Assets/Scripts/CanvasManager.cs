using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class CanvasManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public static CanvasManager instance;
    void Awake()
    {
        instance = this;
    }
    public void UpdateFoodCOunter(int value)
    {
        scoreText.text = value.ToString() + "=";   
    }

}
