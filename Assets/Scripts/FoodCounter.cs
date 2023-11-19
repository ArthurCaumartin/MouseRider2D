using UnityEngine;
using DG.Tweening;

public class FoodCounter : MonoBehaviour
{
    public AnimationCurve foodForm; 
    public int foodCount;
    public void FoodCheck(int foodToAdd)
    {
        Debug.Log("Eat");
        foodCount += foodToAdd;
        // foodCount ++;
        //CanvasManager.instance.UpdateFoodCOunter(foodCount);
        SavePlayerPref.SaveFoodParameter(foodCount);
    }
}
