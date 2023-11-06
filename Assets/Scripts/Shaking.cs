using System.Collections;
using UnityEngine;
using DG.Tweening;
public class Shaking : MonoBehaviour
{
    public bool start = false;
    public float duration = 1.5f;
    void Update()
    {
        if(start == true)
        {
            StartCoroutine(Shake());
        }
    }
    IEnumerator Shake()
    {
        Vector3 startPosition = transform.position;
        float elapsedTime = 0f;

        while(elapsedTime < duration && duration > 0)
        {
            duration = duration - Time.deltaTime;
            elapsedTime += Time.deltaTime;
            transform.position = startPosition + Random.insideUnitSphere;
            yield return null;
        }
        transform.position = startPosition;
    }
}
