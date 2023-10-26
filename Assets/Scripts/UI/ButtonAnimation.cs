using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonAnimation : MonoBehaviour
{
    public float speed;
    public float offSet;
    Vector3 startPos;

    void Start()
    {
        startPos = transform.position;

        speed += Random.Range(-speed * .3f, speed / 2);
        offSet += Random.Range(-offSet * .3f, offSet / 2);
    }

    void Update()
    {
        Vector3 newPos;
        newPos.x = Mathf.Sin(Time.time * speed);
        newPos.y = Mathf.Cos(Time.time * speed);
        newPos.z = 0;
        newPos *= offSet;
        transform.position = newPos + startPos;
    }
}
