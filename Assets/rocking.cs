using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class rocking : MonoBehaviour {

    public GameObject universe;
    float safedistance;
    float distance = 200.0f;
    float force = 1000f;
    int rotate = 360;
    Vector3 randomforce;
    Vector3 position;
    float UniverseRadius;
    float adaptRadius = 1000 * 1/2;
    Vector3 ship_position;

    // Use this for initialization
    void Start () {
        safedistance = distance * 0.30f;

        //this.gameObject.GetComponent<AudioSource>().Stop();

        ship_position = GameObject.FindWithTag("ship").transform.position;
        Random.seed = (int)System.DateTime.Now.Ticks;

        UniverseRadius = GameObject.FindGameObjectWithTag("universe").GetComponent<SphereCollider>().radius;
        distance = UniverseRadius * adaptRadius ;

        position = new Vector3(Random.Range(-distance, distance), Random.Range(-distance, distance), Random.Range(-distance, distance));
  
        while (Vector3.Distance(ship_position, position) < safedistance) {
            position = new Vector3(Random.Range(-distance, distance), Random.Range(-distance, distance), Random.Range(-distance, distance));
        }
        this.transform.position = position;
        this.transform.rotation= new Quaternion(Random.Range(0, rotate), Random.Range(0, rotate), Random.Range(0, rotate), Random.Range(0, rotate));

        randomforce = new Vector3(Random.Range(-force, force), Random.Range(-force, force), Random.Range(-force, force));
        GetComponent<Rigidbody>().AddForce(randomforce, ForceMode.Force);

    }
	
	// Update is called once per frame
	void Update () {
        if (Vector3.Distance(GameObject.FindWithTag("ship").transform.position, this.transform.position) < safedistance)
        {
            GameObject.FindGameObjectWithTag("canvas").GetComponent<Text>().text = "Asteroid chegando";
            GameObject.FindGameObjectWithTag("pointer").transform.LookAt(this.transform.position);
            GameObject.FindGameObjectWithTag("pointer").transform.rotation *= Quaternion.Euler(90,0, 0);
        }
    }


    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "terrain" || other.gameObject.tag == "sun" || other.gameObject.tag == "star" || other.gameObject.tag == "rock")
        {
            this.gameObject.GetComponent<AudioSource>().Play();
            Destroy(this.gameObject);

        }
    }

    void OnTriggerExit(Collider other)
    {

        if (other.gameObject.tag == "universe")
        {
            this.gameObject.GetComponent<Rigidbody>().velocity *= -1;

        }
    }


}