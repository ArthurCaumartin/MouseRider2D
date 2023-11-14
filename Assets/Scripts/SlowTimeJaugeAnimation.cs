using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SlowTimeJaugeAnimation : MonoBehaviour
{

    void Update()
    {
        transform.localPosition = (transform.position - transform.parent.position).normalized;
    }
}
