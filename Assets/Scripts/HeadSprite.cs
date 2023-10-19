using UnityEngine;

public class HeadSprite : MonoBehaviour
{
    public GameObject Head;
    public Vector3 lastFramePosition;
    public void Move()
    {

    }
    private void LateUpdate() 
    {
        Vector3 direction = transform.position - lastFramePosition;
        transform.up = direction;
        lastFramePosition = transform.position;
    }
}
