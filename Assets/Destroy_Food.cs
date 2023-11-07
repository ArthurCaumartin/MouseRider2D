using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Destroy_Food : MonoBehaviour
{
    public AnimationCurve foodForm;
    private void OnTriggerEnter2D(Collider2D other)
    {
        FoodCounter foodCounter = other.GetComponent<FoodCounter>();
        if (foodCounter != null)
        {
            foodCounter.FoodCheck(1);
            transform.DOScale(0f, 1f)
                .SetEase(foodForm)
                .OnComplete(() =>
                {
                    Destroy(gameObject);
                });

        }
        
    }
}
