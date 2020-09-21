using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Scenes : MonoBehaviour
{
    

    public void scene1()
    {
        SceneManager.LoadScene("1");
    }
    public void scene2()
    {
        SceneManager.LoadScene("2");
    }
    public void scene3()
    {
        SceneManager.LoadScene("3");
    }

    public void back()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
