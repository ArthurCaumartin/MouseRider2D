using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SplineMover : MonoBehaviour
{
    [SerializeField] private bool _isLooping;
    [SerializeField] private Spline _spline;
    [SerializeField] private float _speed;
    [SerializeField] private float _distanceOffSet;
    public bool _isMoving = false;
    private float _distance;
    private Vector3 _newPosition = Vector3.zero;
    private Vector3 _lastFramePosition;

    void Start()
    {
        _distance += _distanceOffSet;
    }

    void Update()
    {
        if(!_spline)
        {
            print("Spline not Set to container !");
            return;
        }

        if(!_isMoving)
            return;

        _distance += Time.deltaTime * _speed;
        _newPosition = _spline.computePointWithLength(_distance);

        transform.position = _newPosition;


        if(transform.position == _lastFramePosition)
        {
            if(_isLooping)
            {
                _distance = 0;
                return;
            }
            GameManager.instance.EndLevel();
            _isMoving = false;
        }

        _lastFramePosition = transform.position;
    }

    public void SetSpeed(float value)
    {
        _speed = value;
    }

    public void CanMove(bool value)
    {
        _isMoving = value;
    }
}
