using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public bool isPlayer1Goal;
    public SimpleGameManager gameManager;


    private void Awake()
    {
        gameManager.GetComponent<SimpleGameManager>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
           
           if(isPlayer1Goal == true)
            {
                gameManager.Player2Scored();
            }
            else
            {
                gameManager.Player1Scored();
            }

          
        }
    }
}
