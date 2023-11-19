using UnityEngine;
using DG.Tweening;
public class PlayerDeath : MonoBehaviour
{
    public Shaking shaking;

    [SerializeField] private AudioClip audioDeath = null;

    private AudioSource player_Death;

    // public PlayerMovements playermovement;
   private void OnTriggerEnter2D(Collider2D other) 
   {
        player_Death = GetComponent<AudioSource>();

        if(other.CompareTag ("Obstacle"))
        
        {
          player_Death.PlayOneShot(audioDeath);
          GameManager.instance.RestartScene();
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
  //  private void Update() 
  //  {
  //    playermovement.GetComponent<PlayerMovements>();
  //  }
}
