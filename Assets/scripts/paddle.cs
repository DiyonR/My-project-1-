using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// here is the paddle speed and keybinds of the paddle and what they do
/// </summary>
public class paddle : MonoBehaviour
{
    public float speed = 9f;
    public string leftOrRight;
    public float maxValue = 3.8f;
    public float xSpeed;
    public float ySpeed;





    void PaddleControl(KeyCode up, KeyCode down, KeyCode left, KeyCode right)
    {
        if (Input.GetKey(up) && transform.position.y < maxValue)
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);

        }
        else if (Input.GetKey(down) && transform.position.y > -maxValue)
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime);
        }
        else if (Input.GetKey(left) && transform.position.y > -maxValue)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        else if (Input.GetKey(right) && transform.position.y > -maxValue)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }


    }
   /// <summary>
   /// here all the keybinds that i used for the paddles
   /// </summary>

    // Update is called once per frame
    void Update()
    {   
        if(leftOrRight == "left")
        {
            PaddleControl(KeyCode.W, KeyCode.S, KeyCode.A, KeyCode.D);
            
        } else if(leftOrRight == "right") 
        {
            PaddleControl(KeyCode.UpArrow, KeyCode.DownArrow, KeyCode.LeftArrow, KeyCode.RightArrow);
        } 

    }
}
