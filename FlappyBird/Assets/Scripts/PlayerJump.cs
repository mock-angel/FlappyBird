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
        if (Input.GetButtonDown("Jump"))
        {print("pressed");
            GetComponent<Rigidbody2D>().AddForce(transform.up * thrust);
        }
    }
}
