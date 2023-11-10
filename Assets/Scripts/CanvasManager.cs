using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class CanvasManager : MonoBehaviour
{
    public FoodCounter foodcheck;
    public FoodCounter foodscribe;
    public TextMeshProUGUI scoreText;
    public static CanvasManager instance;
    [SerializeField] Image slowTimeGaugeImage;
    void Awake()
    {
        instance = this;
    }
    public void UpdateSlowtimeGauge(float value)
    {
        slowTimeGaugeImage.fillAmount = value;
    }

    public void UpdateFoodCOunter(int value)
    {
        scoreText.text = value.ToString() + "=";   
    }

}
