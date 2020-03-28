using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneLoader : MonoBehaviour
{
    int currentScene;


    private void Start()
    {
        currentScene  = SceneManager.GetActiveScene().buildIndex;
    }


    public void NextScene()
    {
        SceneManager.LoadScene(currentScene + 1);
    }

    public void StartScene()
    {
        SceneManager.LoadScene(0);
        FindObjectOfType<GameStatus>().ResetScore();

    }

    public void Quit()
    {
        Application.Quit();
    }
}
