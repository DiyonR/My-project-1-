using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using TMPro;
/// <summary>
/// this is how the ball is going to move if it is reset and how fast the ball goes
/// </summary>
public class ball : MonoBehaviour
{
    public float xPosition = 0f;
    public float yPosition = 0f;
    public float xSpeed = 9f;
    public float ySpeed = 9f;


    public TMP_Text scoretext;


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
}
