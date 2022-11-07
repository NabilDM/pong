using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
   public Vector2 speed;

   private Rigidbody2D rig;

   private void Start()
   {
    rig = GetComponent<Rigidbody2D>();
    rig.velocity = speed;
   }

}