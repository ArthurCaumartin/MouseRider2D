using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceOnSpline : MonoBehaviour
{

    public Spline _spline;

    [SerializeField,Range(0,100)] private float _distanceBetweenObject = 1;
    [SerializeField] private bool isRandom;
    [SerializeField] private float x_max;
    [SerializeField] private float x_min;
    [Space]
    [SerializeField] private float y_max;
    [SerializeField] private float y_min;
    [Space]
    [SerializeField] private GameObject _repeteadObject;

    void Start()
    {
        if (_spline == null)
            return;

        if (_repeteadObject == null)
            return;

        for (float distance = 0; distance < _spline.length(); distance += _distanceBetweenObject)
        {
            Vector3 position = _spline.transform.TransformPoint(_spline.computePointWithLength(distance));
            // Orientation orientation = _spline.computeOrientationWithLength(distance, Vector3.up);
            // Quaternion rotation = Quaternion.LookRotation(_spline.transform.TransformDirection(orientation.forward), _spline.transform.TransformDirection(orientation.upward));
            
            if(isRandom)
            {
                position.x += Random.Range(x_min, x_max);
                position.y += Random.Range(y_min, y_max);
            }
            
            GameObject.Instantiate(_repeteadObject, position, Quaternion.identity, this.transform);
        }
    }
}
