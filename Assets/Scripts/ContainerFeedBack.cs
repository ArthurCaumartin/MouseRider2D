using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContainerFeedBack : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _circleSprite;
    [SerializeField] private AnimationCurve _animationCurve;
    
    private PlayerMovements _playerMovements;

    void Start()
    {
        _playerMovements = GetComponentInChildren<PlayerMovements>();
    }
    
    void Update()
    {
        float newAlphaValue = _animationCurve.Evaluate(_playerMovements.GetPlayerPositionRatio());
        _circleSprite.color = GetNewColor(newAlphaValue,  _circleSprite.color);
    }

    Color GetNewColor(float alphaValue, Color color)
    {
        color.a = alphaValue;
        return color;
    }
}
