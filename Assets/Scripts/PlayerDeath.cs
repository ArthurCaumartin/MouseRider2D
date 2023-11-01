using UnityEngine;
using DG.Tweening;
public class PlayerDeath : MonoBehaviour
{
    public Shaking shaking;
    public Camera SizeCamera;
    
   private void OnTriggerEnter2D(Collider2D other) 
   {  
        if(other.CompareTag ("Obstacle"))
        {
            GameManager.instance.EndLevel();
            GetComponentInParent<SplineMover>()._isMoving  = false;
            shaking.GetComponent<Shaking>();
            shaking.start = true;
            new WaitForSeconds(3f);
            CameraDezoom();
        }
   }
   public void CameraDezoom()
   {
        SizeCamera.DOOrthoSize(9f, 3f);
   }
}
