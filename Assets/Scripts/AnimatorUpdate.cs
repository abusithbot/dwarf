using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorUpdate : MonoBehaviour
{
    public Animator anime;
    public Rigidbody2D dwarf2D;
    private void FixedUpdate()
    {
       anime.SetFloat("Speed",dwarf2D.velocity.x);
       anime.SetFloat("yspeed",dwarf2D.velocity.y);
    }
  
}