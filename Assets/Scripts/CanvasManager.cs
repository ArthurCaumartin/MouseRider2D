using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class CanvasManager : MonoBehaviour
{
    public static CanvasManager instance;
    public TextMeshProUGUI scoreText;
    [SerializeField] private RectTransform _tongue;
    [SerializeField] private float _tongueOffset;
    public Vector2 _startTonguePos;

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        _startTonguePos = _tongue.anchoredPosition;
    }

    public void UpdateFoodCOunter(int value)
    {
        scoreText.text = value.ToString() + "=";   
    }

    public void UpdateSlowTimeJauge(float value)
    {
        Vector2 newPosition = _startTonguePos;
        newPosition.x = _startTonguePos.x + _tongueOffset * value;
        _tongue.anchoredPosition = newPosition;
    }
}
