using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class start : MonoBehaviour {

    public Toggle touch;

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

    public void UnloadInstructions()
    {
        SceneManager.LoadScene("start");
    }
    public void Instructions()
    {
        SceneManager.LoadScene("Instructions");
    }

    void Update()
    {
        
        if (touch.isOn)
            PlayerPrefs.SetString("touch", "on");
        else
            PlayerPrefs.SetString("touch", "off");



        if (Input.GetKey(KeyCode.F))
            StartEasyGame();

        else if (Input.GetKey(KeyCode.M))
            StartMediumGame();

        else if (Input.GetKey(KeyCode.D))
            StartHardGame();

        else if (Input.GetKey(KeyCode.R))
            StartRunnerGame();

        else if (Input.GetKey(KeyCode.X))
            ExitGame();

        else if (Input.GetKey(KeyCode.Q))
            UnloadInstructions();
        else if (Input.GetKey(KeyCode.I))
            Instructions();

    }
}
