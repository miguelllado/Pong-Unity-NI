using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SimpleGameManager : MonoBehaviour
{
    [Header("Ball")]
    public GameObject ball;

    [Header("Player 1")]
    public GameObject player1;
    public GameObject player1Goal;

    [Header("Player 2")]
    public GameObject player2;
    public GameObject player2Goal;

    [Header("Score UI")]
    public GameObject player1Text;
    public GameObject player2Text;

    private int player1Score = 0;
    private int player2Score = 0;


    private void Awake()
    {
        player1.GetComponent<PlayerController>();
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    public void Player1Scored()
    {
        player1Score++;
        player1Text.GetComponent<TextMeshProUGUI>().text = player1Score.ToString();
        ResetPos();
    }

    public void Player2Scored()
    {
        player2Score++;
        player2Text.GetComponent<TextMeshProUGUI>().text = player2Score.ToString();
        ResetPos();
    }

    // Update is called once per frame
    void Update()
    {


    }

    public void ResetPos()
    {
        ball.GetComponent<Ball>().ResetPosi();
        player1.GetComponent<PlayerController>().ResetPosition();
        player2.GetComponent<PlayerController>().ResetPosition();
    }

}
