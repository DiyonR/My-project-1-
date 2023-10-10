using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using static UnityEngine.Rendering.VirtualTexturing.Debugging;

public class Collision : MonoBehaviour
{
    public float xPosition = -2f;
    public float yPosition = -2f;
    public float xSpeed = 1f;
    public float ySpeed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(xPosition, yPosition, 0f);
    }

    // Update is called once per frame
    void Update()
    {

        xPosition = xPosition + xSpeed * Time.deltaTime;
        yPosition = yPosition + ySpeed * Time.deltaTime;
        transform.position = new Vector3(xPosition, yPosition, 0f);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Auw!");
        if (collision.gameObject.CompareTag("horizontalWall"))
        {
            Debug.Log("my head or my feet");
            ySpeed = ySpeed * -1f;
        }else if (collision.gameObject.CompareTag("VerticleWall"))
        {
            Debug.Log("my butt or my crotch");
            xSpeed = xSpeed * -1f;
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