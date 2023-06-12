using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{
    public GameObject gameObject;
    public GameObject panel;
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.tag.Equals("Player"))
        {
            panel.SetActive(true);
            gameObject.SetActive(false);
            gameObject.GetComponent<Collider2D>().enabled = false;
            
            PlayerMovement playerMovement = collision.gameObject.GetComponent<PlayerMovement>();
            playerMovement.isMove = false;
        }
    }
}
