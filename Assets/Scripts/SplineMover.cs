using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplineMover : MonoBehaviour
{
    [SerializeField] public bool _isMoving = true;
    [SerializeField] private Spline2D _spline;
    [SerializeField] private float _speed;
    [SerializeField] private float _distanceOffSet;
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
            GameManager.instance.EndLevel();
            _isMoving = false;
        }

        _lastFramePosition = transform.position;
    }
}
