using UnityEngine;
using DG.Tweening;

public class FoodCounter : MonoBehaviour
{
    public AnimationCurve foodForm;
    public int foodCount;
    public ColorSwitch colorswitch;

    public void FoodCheck(int foodToAdd)
    {
        Debug.Log("Eat");
        foodCount += foodToAdd;
        SavePlayerPref.SaveFoodParameter(foodCount);
        if (foodCount == 3)
        {
            CanvasManager.instance.StartFoodColorSwitch();
        }
    }
}
