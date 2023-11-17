using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using System.Collections.Generic;
public class CanvasManager : MonoBehaviour
{
    public FoodCounter foodcounter;
    public static CanvasManager instance;
    public List<Image> FoodImageList = new List<Image>();
    public List<Destroy_Food> FoodList = new List<Destroy_Food>();

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
    void Awake()
    {
        instance = this;
    }
    private void Start() 
    {
        foodcounter.GetComponent<FoodCounter>();
    }
    private void Update() 
    {
        RaimbowMoney();
    }
    public void RaimbowMoney()
    {
        if(foodcounter.foodCount >= 3)
        {
            FoodImageList[0].color = Color.blue;
            FoodImageList[1].color = Color.white;
            FoodImageList[2].color = Color.red;
        }
    }
}
