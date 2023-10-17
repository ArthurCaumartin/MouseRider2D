using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
   private void OnTriggerEnter2D(Collider2D other) 
   {
        if(other.CompareTag ("Obstacle"))
        {
            GameManager.instance.EndLevel();
            GetComponentInParent<SplineMover>()._isMoving  = false;
        }
   }
}
