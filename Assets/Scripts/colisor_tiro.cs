﻿using UnityEngine;
using UnityEngine.UI;

public class colisor_tiro : MonoBehaviour {

   // Use this for initialization
    public GameObject explosion;
    public GameObject bonus;


    void Start () {
        explosion.SetActive(false);
        Destroy(this.gameObject, 4);
    }

	
	// Update is called once per frame
	void Update () {

	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "terrain" || other.gameObject.tag == "sun" || other.gameObject.tag == "star")
        {
            Destroy(this.gameObject);
            Debug.Log(other.gameObject.tag +" me matou");

        }

        else if (other.gameObject.tag.EndsWith("Bonus") || other.gameObject.tag.Contains("ship")) { Debug.Log("Bingo!!!"); }

        else if (other.gameObject.tag != "universe" && other.gameObject.tag != "ship" && other.gameObject.tag != "bullet")
        {
            Destroy(other.gameObject);
            explosion.SetActive(true);
            Debug.Log("matei um " + other.gameObject.tag);
            rocks.destroyeds += 1;
            GameObject.FindGameObjectWithTag("canvas").GetComponent<Text>().text = "Asteroids 3D\n" + rocks.destroyeds + " ateróides destruidos";
            Bonus.newBonus(other.gameObject.transform.position, other.gameObject.transform.rotation);
        }

        
    }
}
