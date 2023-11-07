using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food_Movement : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _offSet;
    private Vector2 _startPos;
    // Start is called before the first frame update
    void Start()
    {
        _startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float time = Mathf.Sin(Time.time * _speed);

        Vector2 newPos = _startPos;
        newPos.y = _offSet * time + _startPos.y;
        transform.position = newPos;
    }
}
