using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;
using UnityEngine.UI;

public class TimeSlower : MonoBehaviour
{
    [SerializeField] private float _slowTimeScale;
    [Space]
    [SerializeField] private int _chargeNumber;
    [SerializeField] private float _durationPerCharge;
    [Space]
    [SerializeField] private float _rechargeCoolDown;
    [SerializeField] private float _timeScaleResetSpeed;
    private float _currentSlowTimeDuration;
    private int _maxChargeNumber;
    private float _cooldownTimer;

    void Start()
    {
        _maxChargeNumber = _chargeNumber;
    }

    void Update()
    {
        Slowtime();
        ChargeCoolDown();
    }

    private void Slowtime()
    {
        if (_currentSlowTimeDuration > 0)
        {
            _currentSlowTimeDuration -= Time.unscaledDeltaTime;
            Time.timeScale = _slowTimeScale;
        }
        else
        {
            Time.timeScale = Mathf.Lerp(Time.timeScale, 1, Time.unscaledDeltaTime * _timeScaleResetSpeed);
        }
    }

    private void ChargeCoolDown()
    {
        if(_chargeNumber < _maxChargeNumber)
        {
            _cooldownTimer += Time.unscaledDeltaTime;
            if(_cooldownTimer > _rechargeCoolDown)
            {
                _chargeNumber++;
                _cooldownTimer = 0;
            }
        }
    }

    void AddSlowTime()
    {
        if(_chargeNumber == 0)
            return;
        
        _chargeNumber -= 1;
        _currentSlowTimeDuration += _durationPerCharge;
    }

    public void OnSlowTime(InputAction.CallbackContext callback)
    {
        if(callback.performed)
        {
            AddSlowTime();
        }
    }

    public float GetFillAmount()
    {
        float maxValue = _rechargeCoolDown * _maxChargeNumber;
        float currentCooldown = (_rechargeCoolDown * _chargeNumber) + _cooldownTimer;
        
        return Mathf.InverseLerp(0, maxValue, currentCooldown);
    }
}
