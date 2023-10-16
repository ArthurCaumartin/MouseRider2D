using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerMovements : MonoBehaviour
{
    public Transform transformPlayer;
    public Vector2 playerPosition;
    private void Update() 
    {
        // transformPlayer = Vector2.Lerp()
        callba
    }
    public void OnMousePosition(InputAction.CallbackContext callback)
    {
        print(callback.ReadValue<Vector2>());
    }

}
