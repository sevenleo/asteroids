using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class start : MonoBehaviour {

    public void StartEasyGame()
    {
        SceneManager.LoadScene("easy");
    }
    public void StartMediumGame()
    {
        SceneManager.LoadScene("medium");
    }
    public void StartHardGame()
    {
        SceneManager.LoadScene("hard");
    }
    public void StartRunnerGame()
    {
        SceneManager.LoadScene("runner");
    }


    void Update()
    {

        if (Input.GetKey(KeyCode.F))
            SceneManager.LoadScene("easy");

        else if (Input.GetKey(KeyCode.M) )
            SceneManager.LoadScene("medium");

        else if (Input.GetKey(KeyCode.D) )
                SceneManager.LoadScene("hard");

        else if (Input.GetKey(KeyCode.R))
            SceneManager.LoadScene("runner");

        else if (Input.GetKey(KeyCode.X) || Input.GetKey(KeyCode.Q) )
            Application.Quit();

    }
}
