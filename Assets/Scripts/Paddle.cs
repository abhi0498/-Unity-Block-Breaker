using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour

{

    //config
    [SerializeField] float screenWidthUnit = 16;
    float minX = 1;
    float maxX = 15f;
    bool autoPlay;
    Ball ball;
    // Start is called before the first frame update
    void Start()
    {
        ball = FindObjectOfType<Ball>();
        autoPlay = FindObjectOfType<GameStatus>().autoPlay;
    }

    // Update is called once per frame
    void Update()
    {
        if (!autoPlay)
        {
            MovePaddleWithMouse();

        }
        else
        {
            MovePaddleWithBall();
        }
    }

    private void MovePaddleWithBall()
    {
        float x = ball.transform.position.x - 0.1f;
        Vector2 paddlePos = new Vector2(transform.position.x, transform.position.y);
        paddlePos.x = Mathf.Clamp(x, minX, maxX);
        transform.position = paddlePos;
    }

    private void MovePaddleWithMouse()
    {
        float x = Input.mousePosition.x / Screen.width * screenWidthUnit;
        Vector2 paddlePos = new Vector2(transform.position.x, transform.position.y);
        paddlePos.x = Mathf.Clamp(x, minX, maxX);

        transform.position = paddlePos;
    }
}
