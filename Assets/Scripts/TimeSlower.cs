using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;

public class TimeSlower : MonoBehaviour
{
    [SerializeField] private bool _isSlowingTime;
    [SerializeField, Range(0.1f, 1f)] private float _slowTimeScale;
    [SerializeField] private float _transitionSpeed;
    [Space]
    [SerializeField] private float _slowTimeUseThresold;
    [SerializeField] private float _maxSlowTimeCappacity;
    [SerializeField] private float _slowTimeDeccay;
    [SerializeField] private float _slowTimeRegen;
    private float _currentSlowTimeCappacity;
    private float currentItmeScale;

    void Update()
    {
        currentItmeScale = Time.timeScale;
        if(_isSlowingTime && _currentSlowTimeCappacity >= _slowTimeUseThresold)
        {
            Time.timeScale = Mathf.Lerp(Time.timeScale, _slowTimeScale, Time.deltaTime * _transitionSpeed);
            _currentSlowTimeCappacity += Time.deltaTime * _slowTimeDeccay;
        }
        else
        {
            Time.timeScale = Mathf.Lerp(Time.timeScale, 1, Time.deltaTime * _transitionSpeed);
            _currentSlowTimeCappacity += Time.deltaTime * _slowTimeRegen;
        }

        _currentSlowTimeCappacity = Mathf.Clamp(_currentSlowTimeCappacity, 0, _maxSlowTimeCappacity);
        CanvasManager.instance.UpdateSlowtimeGauge(Mathf.InverseLerp(_slowTimeUseThresold, _maxSlowTimeCappacity, _currentSlowTimeCappacity));
    }

    public void OnSlowTime(InputAction.CallbackContext callback)
    {
        if(callback.phase == InputActionPhase.Performed)
        {
            _isSlowingTime = true;
        }
        else
        {
            _isSlowingTime = false;
        }
    }
}
