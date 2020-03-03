using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public GameObject gameOverScreen;
    
    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D collision){
        print("runnign here");
        if(collision.gameObject.tag == "walls")
        {
            gameOverScreen.SetActive(true);
            Destroy(gameObject);
        }
    }

}
