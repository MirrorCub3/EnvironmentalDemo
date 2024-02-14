using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerScript : MonoBehaviour
{
    [SerializeField]
    private string introScene, mainScene;

    public void ToIntro()
    {
        SceneManager.LoadScene(introScene);
    }

    public void ToMainScene()
    {
        SceneManager.LoadScene(mainScene);
    }

    public void Reload()
    {
        string currName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(currName);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
