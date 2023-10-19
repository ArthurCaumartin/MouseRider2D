using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasManager : MonoBehaviour
{
    public static CanvasManager instance;
    [SerializeField] Image slowTimeGaugeImage;

    void Awake()
    {
        instance = this;
    }

    public void UpdateSlowtimeGauge(float value)
    {
        slowTimeGaugeImage.fillAmount = value;
    }
}
