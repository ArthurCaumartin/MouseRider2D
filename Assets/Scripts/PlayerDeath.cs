using UnityEngine;
using DG.Tweening;
public class PlayerDeath : MonoBehaviour
{
    public Shaking shaking; 
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
     Camera.main.DOOrthoSize(9f, 3f);
   }
}
