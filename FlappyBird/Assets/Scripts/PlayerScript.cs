using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public GameObject gameOverScreen;
    public GameObject gameWonScreen;
    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D collision){
        if(collision.gameObject.tag == "walls")
        {
            gameOverScreen.SetActive(true);
            Destroy(gameObject);
        }
        if(collision.gameObject.tag == "finish")
        {
            gameWonScreen.SetActive(true);
            Destroy(gameObject);
        }
    }
}
