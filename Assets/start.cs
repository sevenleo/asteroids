using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class start : MonoBehaviour {

    public void StartEasyGame()
    {
        SceneManager.LoadScene("scene1");
    }
    public void StartHardGame()
    {
        SceneManager.LoadScene("scene2");
    }
    void Update()
    {

        if (Input.GetKey(KeyCode.F) )
            SceneManager.LoadScene("scene1");
        if (Input.GetKey(KeyCode.D) )
                SceneManager.LoadScene("scene2");
        if (Input.GetKey(KeyCode.X) || Input.GetKey(KeyCode.Q) )
            Application.Quit();

    }
}
