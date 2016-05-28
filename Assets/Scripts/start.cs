using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class start : MonoBehaviour {

    public void StartEasyGame()
    {
        PlayerPrefs.SetString("level", "easy");
        SceneManager.LoadScene("scene1");
    }
    public void StartMediumGame()
    {
        PlayerPrefs.SetString("level", "medium");
        SceneManager.LoadScene("scene1");
    }
    public void StartHardGame()
    {
        PlayerPrefs.SetString("level", "hard");
        SceneManager.LoadScene("scene1");
    }
    public void StartRunnerGame()
    {
        PlayerPrefs.SetString("level", "runner");
        SceneManager.LoadScene("scene1");
    }
    public void ExitGame()
    {
        Application.Quit();
    }


    void Update()
    {

        if (Input.GetKey(KeyCode.F))
            StartEasyGame();

        else if (Input.GetKey(KeyCode.M))
            StartMediumGame();

        else if (Input.GetKey(KeyCode.D))
            StartHardGame();

        else if (Input.GetKey(KeyCode.R))
            StartRunnerGame();

        else if (Input.GetKey(KeyCode.X) || Input.GetKey(KeyCode.Q))
            ExitGame();

    }
}
