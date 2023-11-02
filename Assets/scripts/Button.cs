using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    public void loadOnePlayer()
    {
        SceneManager.LoadScene("score");
    }
    public void vBot()
    {
        SceneManager.LoadScene("oneplayer");
    }
    public void cancel()
    {
        SceneManager.LoadScene("paddle");
    }
}