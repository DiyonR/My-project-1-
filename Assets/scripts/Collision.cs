using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using static UnityEngine.Rendering.VirtualTexturing.Debugging;
using TMPro;
/// <summary>
/// this code below shows the code of the score and direction if the ball collides
/// </summary>
public class Collision : MonoBehaviour
{
    public float xPosition = -2f;
    public float yPosition = -2f;
    public float xSpeed = 2f;
    public float ySpeed = 2f;
    public TMP_Text scoreText;
    public int leftScore = 0;
    public int rightScore = 0;
    public int winScore = 1;

    /// <summary>
    /// resetball: resets the ball position 
    /// </summary>
    void resetball()
    {
        xPosition = 0f;
        yPosition = 0f;
        xSpeed = xSpeed * -1f;
    }

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(xPosition, yPosition, 0f);
    }

    // Update is called once per frame
    /// <summary>
    /// here below is the code of the win text 
    /// </summary>
    void Update()
    {

        xPosition = xPosition + xSpeed * Time.deltaTime;
        yPosition = yPosition + ySpeed * Time.deltaTime;
        transform.position = new Vector3(xPosition, yPosition, 0f);
        if (leftScore >= winScore)
        {
            scoreText.text = "Left Player Has Won";
            xPosition = 0f;
            yPosition = 0f;
        }
        else if (rightScore >= winScore) 
        {
            scoreText.text = "Right Player Has Won";
            xPosition = 0f;
            yPosition = 0f;
        }
    }
    /// <summary>
    /// here below is the code of the walls and paddles so the ball can bounce off
    /// </summary>

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Auw!");
        if (collision.gameObject.CompareTag("horizontalWall"))
        {
            Debug.Log("my head or my feet");
            ySpeed = ySpeed * -1f;
        }else if (collision.gameObject.CompareTag("verticalLeft"))
        {
            Debug.Log("my butt or my crotch");
            
            resetball();
            rightScore++;
            scoreText.text = leftScore + " - " + rightScore;
        }
        else if (collision.gameObject.CompareTag("verticalRight"))
        {
            Debug.Log("my butt or my crotch");

            resetball();
            leftScore++;
            scoreText.text = leftScore + " - " + rightScore;
        }
        Debug.Log("Ha");
        if (collision.gameObject.CompareTag("LeftPaddle"))
        {
            Debug.Log("LP");
            ySpeed = ySpeed * 1f;
            xSpeed = xSpeed * -1f;
        }
        else if (collision.gameObject.CompareTag("RightPaddle"))
        {
            Debug.Log("RP");
            xSpeed = xSpeed * -1f;
        }
    }
}