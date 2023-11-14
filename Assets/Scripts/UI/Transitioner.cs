using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class Transitioner : MonoBehaviour
{
    public static Transitioner instance;
    [SerializeField] private float _transitionDuration;
    [SerializeField] private AnimationCurve _transitionAnimation;
    private Image _image;
    private Vector3 _scaleStart;
    private Vector3 _scaleTarget;

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        print("Transitioner Call Start !");
        _image = GetComponentInChildren<Image>();
        _image.transform.localScale = Vector3.zero;
    }

    public void DoGameTransition(bool doesAnimationGoesIn, Action afterTransition)
    {
        if(doesAnimationGoesIn)
        {
            _scaleStart = Vector3.one;
            _scaleTarget = Vector3.zero;
        }
        else
        {
            _scaleStart = Vector3.zero;
            _scaleTarget = Vector3.one;
        }

        _image.transform.localScale = _scaleStart;
        _image.transform.DOScale(_scaleTarget, _transitionDuration)
        .SetEase(_transitionAnimation)
        .SetUpdate(true)
        .OnComplete(() =>
        {
            if(afterTransition != null)
                afterTransition.Invoke();
        });
    }
}
