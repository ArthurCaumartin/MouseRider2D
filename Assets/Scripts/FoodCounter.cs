using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
using TMPro;
using System;
public class FoodCounter : MonoBehaviour
{
    public TMP_Text scoreText;
    public AnimationCurve foodForm; 
    public int foodCount;
    public void FoodCheck(int foodToAdd)
    {
        Debug.Log("Eat");
        foodCount += foodToAdd;
        scoreText.text = foodCount.ToString() + "=";
        if (foodCount == 3)
        {
        }
    }
}
