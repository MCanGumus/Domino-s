using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrueorFalse : MonoBehaviour
{
    public GameObject gameObject;
    public Button btn;
    public GameObject player;

    public void TrueAnswer()
    {
        
        var btnImage = btn.GetComponent<Image>();
        btnImage.color = Color.green;
        gameObject.SetActive(false);
        PlayerMovement playerMovement = player.GetComponent<PlayerMovement>();
        playerMovement.isMove = true;
        playerMovement.questionAnswers++;
    }

    public void FalseAnswer()
    {
        var btnImage = btn.GetComponent<Image>();
        btnImage.color = Color.red;
    }
}
