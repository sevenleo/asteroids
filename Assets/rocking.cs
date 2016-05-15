using UnityEngine;
using System.Collections;

public class rocking : MonoBehaviour {
    public GameObject universe;
    float distance = 500.0f;
    float force = 1000f;
    int rotate = 180;
    Vector3 randomforce;
    Vector3 safedistance;
    float RaioDoUniverso;

    // Use this for initialization
    void Start () {
        Random.seed = (int)System.DateTime.Now.Ticks;

        RaioDoUniverso = GameObject.FindGameObjectWithTag("universe").GetComponent<SphereCollider>().radius;
        distance = RaioDoUniverso * 900 ;
        safedistance = GameObject.FindWithTag("ship").transform.position + new Vector3(RaioDoUniverso * 30, RaioDoUniverso * 30, RaioDoUniverso * 30);

        this.transform.position= safedistance + new Vector3(Random.Range(-distance, distance), Random.Range(-distance, distance), Random.Range(-distance, distance));
        this.transform.rotation= new Quaternion(Random.Range(-rotate, rotate), Random.Range(-rotate, rotate), Random.Range(-rotate, rotate), rotate);

        randomforce = new Vector3(Random.Range(-force, force), Random.Range(-force, force), Random.Range(-force, force));
        GetComponent<Rigidbody>().AddForce(randomforce, ForceMode.Force);

    }
	
	// Update is called once per frame
	void Update () {

    }

    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "terrain" || other.gameObject.tag == "sun" || other.gameObject.tag == "star" || other.gameObject.tag == "rock")
        {
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
