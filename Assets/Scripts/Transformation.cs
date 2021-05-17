using UnityEngine;

public class Transformation : MonoBehaviour
{

  public Animator animator;
  public Animator animatorChild;
  public GetTransformed child;
  public bool wilt ;

  /*public static Transformation instance ;

  private void Awake()
  {
      if(instance != null){
        Debug.LogWarning("Il y a plus d'un Transformation");
        return ;
      }
      instance = this;
  }*/

  private void OnCollisionEnter2D(Collision2D collision)
  {
      if(collision.transform.CompareTag("Player") && wilt)
      {
        animator.SetTrigger("New Trigger 0");
        animatorChild.SetTrigger("New Trigger 0");
        wilt = false;
      }
      else if(collision.transform.CompareTag("Player") && !wilt){
        animator.SetTrigger("New Trigger");
        animatorChild.SetTrigger("New Trigger");
        wilt = true;
      }

  }
}
