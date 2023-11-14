using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class MenuFoodContainer : MonoBehaviour
{
    [SerializeField] private int _levelIndex;
    [SerializeField] private Color _activeColor;
    [SerializeField] private List<Image> _foodImage;

    void Start()
    {
        int[] foodParameter = SavePlayerPref.GetFoodParameter();
        SetColor(foodParameter[_levelIndex]);
    }

    public void SetColor(int numbreOfFoodToColor)
    {
        for (int i = 0; i < numbreOfFoodToColor; i++)
        {
            _foodImage[i].color = _activeColor;
        }
    }
}
