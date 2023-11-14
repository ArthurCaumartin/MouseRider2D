using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;

public class OnTriggerEvent : MonoBehaviour
{
    [SerializeField] private string _tagToTrigger;
    [SerializeField] private bool _dontDisableOnTrigger;
    [SerializeField] private UnityEvent _onTriggerEvent;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == _tagToTrigger)
        {
            _onTriggerEvent.Invoke();
            if(!_dontDisableOnTrigger)
                gameObject.SetActive(false);
        }
    }    
}
