using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class colisor_tiro : MonoBehaviour {

    // Use this for initialization
    
    void Start () {
        Debug.Log("Disparei");
        Destroy(this.gameObject, 10);
    }

	
	// Update is called once per frame
	void Update () {

	}

    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);
        if (other.tag == "terrain" || other.tag == "sun" || other.tag == "star")
        {
            Destroy(this.gameObject);
            Debug.Log("Me matou");

        }
        if (other.gameObject.tag == "bullet")
        {
            Destroy(this.gameObject);
            Debug.Log("brothers 4ever");
        }
        else if (other.gameObject.tag != "ship")
        {
            Destroy(other.gameObject);
            Debug.Log("matei");
        }

        
    }
}
