using UnityEngine;
using DG.Tweening;

public class FoodCounter : MonoBehaviour
{
    public bool scribescore = false;
    public AnimationCurve foodForm; 
    public int foodCount;
    public void FoodCheck(int foodToAdd)
    {
        Debug.Log("Eat");
        foodCount += foodToAdd;
        CanvasManager.instance.UpdateFoodCOunter(foodCount);
        SavePlayerPref.SaveFoodParameter(foodCount);
        if (foodCount == 3)
        {
            
        }
    }
}
