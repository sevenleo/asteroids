using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameover : MonoBehaviour {


	
	// Update is called once per frame
	void Update () {
        
        this.GetComponent<Text>().text = "Você destruiu " + rocks.destroyeds + " ateróides";

        if (Input.GetKey(KeyCode.P)){
            SceneManager.LoadScene("start");
        }

        if (Input.GetKey(KeyCode.X))
        {
            Application.Quit();
            
        }
    }
}
    