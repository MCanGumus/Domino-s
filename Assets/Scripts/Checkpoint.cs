using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            PlayerMovement playerMovement = collision.gameObject.GetComponent<PlayerMovement>();
            playerMovement.respawnPoint = new Vector3(transform.position.x, transform.position.y + 3,0);
            //Canvas
            gameObject.GetComponent<Collider2D>().enabled = false;
        }
    }
}
