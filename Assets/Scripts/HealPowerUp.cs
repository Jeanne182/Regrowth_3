using UnityEngine;

public class HealPowerUp : MonoBehaviour
{
  public int healthPoints ;
  public AudioClip pickUpSound;
  private void OnTriggerEnter2D(Collider2D collision)
  {
    if(collision.CompareTag("Player")){
      AudioManager.instance.PlayClipAt(pickUpSound, transform.position);
      PlayerHealth.instance.HealPlayer(healthPoints);
      Destroy(gameObject);
    }
  }
}
