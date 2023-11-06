using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerMovements : MonoBehaviour
{
    [SerializeField] private float _distanceMax;
    [SerializeField] private float _speed;
    private float _playerDistance;

    private Vector2 _worldMousePosition;
    private Vector2 _containerMousePosition;

    private Vector2 _screenCenter;
    private Vector2 _screenCenterWorldPos;

    private Vector2 velocity;


    private void Update()
    {

        ComputeVariable();

        Vector2 positionToSet;
        positionToSet = SetPositionToSet();

        // transform.localPosition = Vector2.Lerp(transform.localPosition, positionToSet, Time.deltaTime * _speed);
        transform.localPosition = Vector2.SmoothDamp(transform.localPosition, positionToSet, ref velocity, _speed, Mathf.Infinity, Time.unscaledDeltaTime);
    }

    private Vector2 SetPositionToSet()
    {
        Vector2 positionToSet;
        if (Vector2.Distance(_screenCenterWorldPos, _worldMousePosition) < _distanceMax)
        {
            print("In range");
            positionToSet = _containerMousePosition;
        }
        else
        {
            print("Not In range");
            positionToSet = (_worldMousePosition - _screenCenterWorldPos).normalized * _distanceMax;
        }

        return positionToSet;
    }

    private void ComputeVariable()
    {
        _worldMousePosition = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        _containerMousePosition = transform.parent.InverseTransformPoint(_worldMousePosition);

        _screenCenter = new Vector2(Camera.main.pixelWidth / 2, Camera.main.pixelHeight / 2);
        _screenCenterWorldPos = Camera.main.ScreenToWorldPoint(_screenCenter);

        _playerDistance = Vector2.Distance(_screenCenterWorldPos, transform.position);
    }

    public float GetPlayerPositionRatio()
    {
        return Mathf.InverseLerp(0, _distanceMax, _playerDistance);
    }
}