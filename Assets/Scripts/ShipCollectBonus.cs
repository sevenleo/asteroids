using UnityEngine;
using System.Collections;

public class ShipCollectBonus : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GameObject.FindGameObjectWithTag("ship2").GetComponent<Renderer>().enabled = false;
        GameObject.FindGameObjectWithTag("ship2trail").GetComponent<Renderer>().enabled = false;
        GameObject.FindGameObjectWithTag("ship2cannon").GetComponent<Renderer>().enabled = false;
    }

    // Update is called once per frame
    void Update () {
	
	}


    void OnTriggerEnter(Collider other){

        if (other.gameObject.tag.EndsWith("Bonus"))
        {
            GameObject.FindGameObjectWithTag("Bonus").GetComponent<AudioSource>().Play();
        }

        if (other.tag == "LifeBonus")
        {
            Destroy(other.gameObject);
            levels.lifes++;
        }
        else if (other.tag == "SpeedBonus")
        {
            Destroy(other.gameObject);
            levels.turbo = true;
        }
        else if (other.tag == "TimeBonus")
        {
            Destroy(other.gameObject);
            PlayerPrefs.SetString("level", "easy");
        }
        else if (other.tag == "DeadBonus")
        {
            Destroy(other.gameObject);
            PlayerPrefs.SetString("level", "hard");
            levels.lifes = 1;
        }
        else if (other.tag == "FireBonus")
        {
            Destroy(other.gameObject);
            levels.fireRate -= 0.1f;
        }
        else if (other.tag == "StarBonus")
        {
            Destroy(other.gameObject);
            GameObject.FindGameObjectWithTag("ship").GetComponent<Renderer>().enabled = false;
            GameObject.FindGameObjectWithTag("ship2").GetComponent<Renderer>().enabled = true;
            GameObject.FindGameObjectWithTag("ship2trail").GetComponent<Renderer>().enabled = true;
            GameObject.FindGameObjectWithTag("ship2cannon").GetComponent<Renderer>().enabled = true;
            levels.fireRate *= 2f;
            levels.turbo = true;
            levels.lifes++;
        }

    }


    }
