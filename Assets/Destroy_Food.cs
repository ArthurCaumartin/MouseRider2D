using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Destroy_Food : MonoBehaviour
{
    [SerializeField] float AnimationDuration;
    public AnimationCurve foodForm;
    private void OnTriggerEnter2D(Collider2D other)
    {
        FoodCounter foodCounter = other.GetComponent<FoodCounter>();
        ParticleSystem particle = GetComponentInChildren<ParticleSystem>();
        particle.Play();
        CanvasManager.instance.ScoreUPdateFood(this);
        if (foodCounter != null)
        {
            foodCounter.FoodCheck(1);
            transform.DOScale(0f, AnimationDuration)
                .SetEase(foodForm)
                .OnComplete(() =>
                {

                    particle.transform.parent = null;
                    Destroy(gameObject);

                });

        }

    }
}
