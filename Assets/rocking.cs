using UnityEngine;
using System.Collections;

public class rocking : MonoBehaviour {
    
    float distance = 1000.0f;
    float force = 1000f;
    int rotate = 180;
    Vector3 randomforce;
    Vector3 safedistance;


    // Use this for initialization
    void Start () {
        Random.seed = (int)System.DateTime.Now.Ticks;
        safedistance = GameObject.FindWithTag("ship").transform.position + new Vector3(10, 10, 10);

        this.transform.position= safedistance + new Vector3(Random.Range(-distance, distance), Random.Range(-distance, distance), Random.Range(-distance, distance));
        this.transform.rotation= new Quaternion(Random.Range(-rotate, rotate), Random.Range(-rotate, rotate), Random.Range(-rotate, rotate), rotate);

        randomforce = new Vector3(Random.Range(-force, force), Random.Range(-force, force), Random.Range(-force, force));
        GetComponent<Rigidbody>().AddForce(randomforce, ForceMode.Force);

    }
	
	// Update is called once per frame
	void Update () {

    }
}
