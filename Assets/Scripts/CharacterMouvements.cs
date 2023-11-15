using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMouvements : MonoBehaviour
{
    public float speed;
    public float MaxSpeed = 10f;
    Vector2 dir;
    private Rigidbody2D bodyRef;

    void Start()
    {
        bodyRef = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        Input.GetAxis("Horizontal");

        float horizontal = Input.GetAxis("Horizontal");


        //appeler apres avoir declarer horizonta et vertical sinon ca marche pas 
        dir = new Vector2 (horizontal, 0 );

        dir = dir.normalized;  

        Debug.DrawRay(transform.position, dir * 5, Color.red);

        dir = dir * speed;


    }

    private void FixedUpdate()
    {
        bodyRef.AddForce(dir);

        if(bodyRef.velocity.x > MaxSpeed ) 
         { 
            bodyRef.velocity = new Vector2(MaxSpeed, bodyRef.velocity.y);        
          }

        if (bodyRef.velocity.x < MaxSpeed *-1)
        {
            bodyRef.velocity = new Vector2(MaxSpeed * -1, bodyRef.velocity.y);
        }
    }
}
