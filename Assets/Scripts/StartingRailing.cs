using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartingRailing : MonoBehaviour
{
    public GameObject cnvWelcome;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            cnvWelcome.SetActive(true);
            //Canvas
            gameObject.GetComponent<Collider2D>().enabled = false;
            PlayerMovement playerMovement = collision.gameObject.GetComponent<PlayerMovement>();
            playerMovement.isMove = false;
        }
    }
    
}
