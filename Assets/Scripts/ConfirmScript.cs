using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ConfirmScript : MonoBehaviour
{
    public GameObject gameObject;
    public GameObject player;
    public void Confirm()
    {
        gameObject.SetActive(false);
        PlayerMovement playerMovement = player.GetComponent<PlayerMovement>();
        playerMovement.isMove = true;

    }
    public void EndGameTurnBackMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
