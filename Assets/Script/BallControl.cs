using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{

   public AudioSource audioPlayer;
   public Vector2 speed;
   //[SerializeField] private AudioSource _audio;
   public Vector2 resetPosition;

   private Rigidbody2D rig;

   private void Start()
   {
      rig = GetComponent<Rigidbody2D>();
      rig.velocity = speed;
   }

   private void OnCollisionEnter2D(Collision2D collision)
   {
      //_audio.Play();
      if(collision.gameObject.name.Equals("Right"))
      {
            float y = hitFactor(
               transform.position,
               collision.gameObject.transform.position,
               collision.collider.bounds.size.y);
            Vector2 dir = new Vector2(-1, y).normalized;
            rig.velocity = dir * speed.x;
            Debug.Log("YHIT"+y);
            
      }
     if(collision.gameObject.name.Equals("Left"))
      {
            float y = hitFactor(
               transform.position,
               collision.gameObject.transform.position,
               collision.collider.bounds.size.y);
            Vector2 dir = new Vector2(-1, y).normalized;
            rig.velocity = dir * speed.x;
            Debug.Log("YHIT"+y);
      }    
      
      if(collision.gameObject.tag == "CollisionTag"){
         audioPlayer.Play();
      }

   }

   float hitFactor(Vector2 ballPos, Vector2 paddlePos, float paddleHeight)
   {



      return (ballPos.y - paddlePos.y) / paddleHeight;
   }

   public void ResetBall()
   {
      transform.position = new Vector3(resetPosition.x, resetPosition.y, 2);
   }

   public void ActivatePUSpeedUP(float magnitude)
   {
      rig.velocity *= magnitude;
   }


}

