using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class FoodCounter : MonoBehaviour
{
    public AnimationCurve foodForm; 
    public int foodCount;

    public void FoodCheck(int foodToAdd)
    {
        foodCount += foodToAdd;
        if (foodCount == 3)
        {
            Debug.Log("AllFood");
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
