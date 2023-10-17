using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerMovements : MonoBehaviour
{
    public GameObject Player;
    public float distanceMax;
    public float speed;
    Vector2 centerWorldPos;
    Vector2 mousePos;

    private void Update() 
    {
        Vector2 positionToSet;
        
        mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());

        Vector2 center = new Vector2(Camera.main.pixelWidth / 2, Camera.main.pixelHeight / 2);
        centerWorldPos = Camera.main.ScreenToWorldPoint(center);

        if(Vector2.Distance(centerWorldPos, mousePos) > distanceMax)
            positionToSet = (mousePos - centerWorldPos).normalized * distanceMax;
        else
            positionToSet = mousePos;

        transform.position = Vector2.Lerp(transform.position, positionToSet, Time.deltaTime* speed);
    }
}