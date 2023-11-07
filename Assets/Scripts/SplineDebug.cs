using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplineDebug : MonoBehaviour
{
    [SerializeField] private Spline _spline;
    [SerializeField] private Color _color;
    [SerializeField, Range(.01f, 1)] private float _raduis;
    [SerializeField, Range(0.001f, .5f)] private float _gap;

    void OnDrawGizmos()
    {
        if(!_spline || _gap < 0.001)
            return;

        Gizmos.color = _color;
        for(float i = 0; i < _spline.length(); i += _gap)
        {
            Gizmos.DrawSphere(_spline.computePoint(i), _raduis);
        }
    }
}
