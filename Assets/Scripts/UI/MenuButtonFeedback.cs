using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MenuButtonFeedback : MonoBehaviour
{
    [SerializeField] private Transform _maskTransform;    
    [SerializeField] private float _speed;
    [SerializeField] bool _resetOnEvent;
    [SerializeField] private UnityEvent _onCompleteEvent;
    private bool _isMouseOver = false;
    private float _time;
    private Vector2 _velocity;

    void Update()
    {
        _time += _isMouseOver ? Time.deltaTime * _speed : -Time.deltaTime * _speed;
        _time = Mathf.Clamp(_time, 0, 1);
        _maskTransform.localScale = Vector2.one * _time;

        if(_time >= 1f && _resetOnEvent)
        {
            _isMouseOver = false;
            _time = 0;
            _onCompleteEvent.Invoke();
        }
    }

    //! Call by TriggerEvent
    public void SetMouseOver(bool value)
    {
        _isMouseOver = value;
    }
}
