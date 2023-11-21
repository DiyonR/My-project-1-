using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
/// <summary>
/// here i made the loading scenes of the buttons in the menu so what they do is if you click a button it loads the scene of a gamemode
/// </summary>
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