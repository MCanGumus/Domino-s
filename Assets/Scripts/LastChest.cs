using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LastChest : MonoBehaviour
{
    public GameObject pointChest;
    public GameObject groundChest;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        PlayerMovement player = collision.gameObject.GetComponent<PlayerMovement>();
        if (collision.gameObject.tag.Equals("Player"))
        {
            player.takenChest = true;
            groundChest.SetActive(false);
            pointChest.SetActive(true);
            //Canvas
            gameObject.GetComponent<Collider2D>().enabled = false;
        }
    }
}
