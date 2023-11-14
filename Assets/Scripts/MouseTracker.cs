using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using UnityEngine;

public class MouseTracker : MonoBehaviour
{
    public Vector2 _offSet;
    private Vector2 _worldMousePosition;
    private Image _image;
    private TimeSlower _timeSlower;

    void Start()
    {
        Cursor.visible = false;
        _image = GetComponentInChildren<Image>();
        _timeSlower = GameObject.FindGameObjectWithTag("Player").GetComponent<TimeSlower>();
    }

    void Update()
    {
        _worldMousePosition = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        transform.position = _worldMousePosition + _offSet;

        float fill = _timeSlower.GetFillAmount();
        print("Slow time fill = " + fill);
        _image.fillAmount = fill;
    }
}
