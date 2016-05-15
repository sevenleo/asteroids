using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameover : MonoBehaviour {

	// Use this for initialization
	void Start () {
        SceneManager.UnloadScene("scene1");
    }
	
	// Update is called once per frame
	void Update () {
        
        this.GetComponent<Text>().text = "Asteroids 3D\n\n\n" 
                                    + "Você destruiu " + rocks.destroyeds + " ateróides"
                                    +"\n\nPressione espaço para jogar novamente ou X para terminar";

        if (Input.GetKey(KeyCode.Space)){
            SceneManager.LoadScene("scene1");
        }
        if (Input.GetKey(KeyCode.X))
        {
            
        }
    }
}
    