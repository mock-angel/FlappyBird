using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
////    [Range(1, 50)]
    public float thrust = 600f;
    public LayerMask groundLayer;
    
    void Update()
    {
//        print("pressed");
        if (Input.GetButton("Jump") || Input.touchCount > 0)
        {
//            GetComponent<Rigidbody2D>().AddForce(transform.up * thrust);
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 3f);
        }
    }
}
