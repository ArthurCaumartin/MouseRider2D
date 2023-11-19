using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ColorSwitch : MonoBehaviour
{
    public float speed;
    public float Offset;
    public bool switchColor = false;

    private Color newColor = Color.black;
    private float hue;
    private Image image;

    void Start()
    {
        image = GetComponent<Image>();
    }

    void Update()
    {
        if(switchColor)
        {
            hue = Mathf.InverseLerp(-1, 1, Mathf.Sin(Offset +Time.time * speed));
            newColor = Color.HSVToRGB(hue, 1, 1);
            image.color = newColor;
        }
    }
}
