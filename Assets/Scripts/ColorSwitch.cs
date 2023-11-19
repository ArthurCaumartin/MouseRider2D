using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ColorSwitch : MonoBehaviour
{
    public Color newColor = Color.black;
    public float hue;
    public bool switchColor = true;
    public Image image;
    public float speed;
    public float Offset;
    void Start()
    {
        // image.GetComponent<>();
    }
    void Update()
    {
        if(switchColor == true)
        {
            hue = Mathf.InverseLerp(-1, 1, Mathf.Sin(Time.time));
            newColor = Color.HSVToRGB(hue, 1, 1);
            image.color = newColor;
        }
    }
}
