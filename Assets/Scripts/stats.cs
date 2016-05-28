using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class stats : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        GameObject.FindGameObjectWithTag("ingamelifes").GetComponent<Text>().text = "Vidas:" + levels.lifes;
        GameObject.FindGameObjectWithTag("ingamescore").GetComponent<Text>().text = "Destruidos: " + rocks.destroyeds + "/" + rocks.stones + "/" + levels.RocksQuantity;
        if (Input.GetKey(KeyCode.X))
            SceneManager.LoadScene("start");
    }
}
