using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class colisor_tiro : MonoBehaviour {

    public GameObject bullet;
    public float shootspeed = 10.0f;


    // Use this for initialization
    void Start () {
        Physics.IgnoreCollision(bullet.GetComponent<Collider>(), this.GetComponent<Collider>());
    }

	
	// Update is called once per frame
	void Update () {


        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(1))
        {
            Rigidbody bulletinstace = Instantiate(bullet, transform.position, transform.rotation) as Rigidbody;
            bulletinstace.velocity = transform.forward * shootspeed;
        }
	
	}

    void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "Stone_5")        {
            SceneManager.LoadScene("scene1");
        }
        else if (other.tag == "ship" || other.tag == "bullet" )        {
        }
        else if (other.tag == "terrain" || other.tag == "sun" || other.tag =="star") {
        }

        else{
            Destroy(other.gameObject);
        }
        

    }
}
