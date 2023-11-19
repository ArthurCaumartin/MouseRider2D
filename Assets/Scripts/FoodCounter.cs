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
        // foodCount ++;
        //CanvasManager.instance.UpdateFoodCOunter(foodCount);
        SavePlayerPref.SaveFoodParameter(foodCount);
    }
    private void Update() 
    {
        Debug.Log(foodCount);
        colorswitch.GetComponent<ColorSwitch>();
        if(foodCount == 3)
        {
           colorswitch.switchColor = true; 
        }
    }
}
