using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndingRailing : MonoBehaviour
{
    public GameObject gameObject;
    public GameObject player;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        PlayerMovement playerSpes = player.GetComponent<PlayerMovement>();
        if (collision.gameObject.tag.Equals("Player"))
        {
            if(playerSpes.questionAnswers == 2 && playerSpes.takenChest)
            {
                gameObject.SetActive(true);

                PlayerMovement playerMovement = collision.gameObject.GetComponent<PlayerMovement>();
                playerMovement.isMove = false;

            }
           
        }
    }
}
