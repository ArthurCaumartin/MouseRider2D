using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplineMover : MonoBehaviour
{
    [SerializeField] SplineBest _spline;
    [SerializeField] private float _speed;
    [SerializeField] private float _distance;
    Vector3 _newPosition;

    void Update()
    {
        _distance += Time.deltaTime * _speed;
        _newPosition = _spline.computePointWithLength(_distance);
        transform.position = _newPosition;
    }
}
