using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using System.Collections.Generic;
public class CanvasManager : MonoBehaviour
{
    public static CanvasManager instance;
    public List<Image> FoodImageList = new List<Image>();
    public List<Destroy_Food> FoodList = new List<Destroy_Food>();

    void Awake()
    {
        instance = this;
    }

    public void ScoreUPdateFood(Destroy_Food caller)
    {
        int index = 0;
        for (int i = 0; i < FoodList.Count; i++)
        {
            if (caller == FoodList[i])
            {
                index = i;
                break;
            }
        }
        FoodImageList[index].color = Color.yellow;
    }

    public void StartFoodColorSwitch()
    {
        for (int i = 0; i < FoodImageList.Count; i++)
        {
            FoodImageList[i].GetComponent<ColorSwitch>().switchColor = true;
        }
    }
}
