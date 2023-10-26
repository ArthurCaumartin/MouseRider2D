using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceOnSpline : MonoBehaviour
{

    public Spline2D _spline;

    [SerializeField,Range(0,100)] private float _distanceBetweenObject = 1;
    [SerializeField] private Vector2 _offSet;
    [SerializeField, Range(0, 100)] private float _startFreeZone;
    [SerializeField, Range(0, 100)] private float _endFreeZone;

    [SerializeField] private GameObject _repeteadObject;



    // Start is called before the first frame update
    void Start()
    {
        if (_spline == null)
            return;

        if (_repeteadObject == null)
            return;

        for (float distance = _startFreeZone; distance < _spline.length() - _endFreeZone; distance += _distanceBetweenObject)
        {
            Vector2 position = _spline.transform.TransformPoint(_spline.computePointWithLength(distance));
            // Orientation orientation = _spline.computeOrientationWithRMFWithLength(distance);
            // Quaternion rotation = Quaternion.LookRotation(_spline.transform.TransformDirection(orientation.forward), _spline.transform.TransformDirection(orientation.upward));
            // Vector3 offsetX = transform.TransformDirection(rotation * Vector3.right * Random.Range(-5f, 5f));
            // Vector3 offsetY = transform.TransformDirection(rotation * Vector3.up * Random.Range(1f, 3f));

            Vector2 offSetToSet;
            offSetToSet.x = Random.Range(-_offSet.x, _offSet.x);
            offSetToSet.y = Random.Range(-_offSet.y, _offSet.y);

            Vector3 eulerRandom = new Vector3(0, 0, Random.Range(0, 360));
            GameObject.Instantiate(_repeteadObject, position + offSetToSet, Quaternion.Euler(eulerRandom), transform);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
