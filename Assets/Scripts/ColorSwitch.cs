using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ColorSwitch : MonoBehaviour
{
    public Color newColor = Color.black;
    public float hue;
    public bool switchColor = false;
    public Image image;
    public float speed;
    public float Offset;
    public FoodCounter foodcounter;
    void Start()
    {
        image = GetComponent<Image>();
    }
    void Update()
    {
        foodcounter.GetComponent<FoodCounter>();
        Debug.Log(switchColor);
        if(foodcounter.foodCount == 3)
        {
            hue = Mathf.InverseLerp(-1, 1, Mathf.Sin(Time.time));
            newColor = Color.HSVToRGB(hue, 1, 1);
            image.color = newColor;
        }
    }
}
