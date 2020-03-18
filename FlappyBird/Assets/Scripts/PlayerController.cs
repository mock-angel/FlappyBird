using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float runSpeed = 10f;
    public float thrustVelocity = 8f;
    
    private Rigidbody2D rb;
    
    Vector3 movement;
    
    void Start(){
        rb = gameObject.GetComponent<Rigidbody2D>();
        
        movement.x = 1;
        movement.y = 0;
        movement.z = 0;
        
        rb.velocity = new Vector2(runSpeed, 0);
    }
    
    void Update()
    {
        if (Input.GetButton("Jump") || Input.touchCount > 0)
        {
            rb.velocity = new Vector2(runSpeed, thrustVelocity);
        }
    }
}
