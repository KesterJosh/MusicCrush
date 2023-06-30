using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMovement : MonoBehaviour
{
    public void LevelScene()
    {
        SceneManager.LoadScene("Level");
    }

    public void HomeScene()
    {
        SceneManager.LoadScene("Home");
    }

    public void LevelOne()
    {
        SceneManager.LoadScene("Game Scene");
    }
}
