using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameover : MonoBehaviour {


	
	// Update is called once per frame
	void Update () {


        GameObject.FindGameObjectWithTag("gameoverscoreA").GetComponent<Text>().text = "Surgiram " + rocks.stones + " asteróides";
        GameObject.FindGameObjectWithTag("gameoverscoreB").GetComponent<Text>().text = "Você destruiu " + rocks.destroyeds; 

        if (Input.GetKey(KeyCode.P)){
            SceneManager.LoadScene("start");
        }

        if (Input.GetKey(KeyCode.X))
        {
            Application.Quit();
            
        }
    }
}
    