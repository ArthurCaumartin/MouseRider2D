using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerMovements : MonoBehaviour
{
    public GameObject Player;
    public Vector2 playerPosition;
    private void Update() 
    {
        Vector3 mousePos = Mouse.current.position.ReadValue();
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);
        Player.transform.position = new Vector2(mousePos.x, mousePos.y);
        // transformPlayer = Vector2.Lerp()
        // mousePos.z=Camera.main.nearClipPlane;
    }
    public void OnMousePosition(InputAction.CallbackContext callback)
    {
        // print(callback.ReadValue<Vector2>());
    }

}
