using UnityEngine;
using System.Collections;


public class Shoot : MonoBehaviour {
	public Rigidbody bullet;
    public float speed = 0.1f;
    
    // Use this for initialization
    void Start () {
	    //bullet.transform.position=this.transform.position;
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown(KeyCode.Space)  || Input.GetMouseButtonDown(0))  {

            /*
            bullet.transform.position=this.transform.position;
            bullet.GetComponent<Rigidbody>().velocity = this.transform.forward;
            //bullet.AddForce(transform.position * speed);
            */

           
            Rigidbody bulletinstace = Instantiate(bullet, transform.position, transform.rotation) as Rigidbody;
            //bulletinstace.velocity = new Vector3(0, 0, speed);
            bulletinstace.velocity = transform.forward * speed;
            //bulletinstace.AddForce(transform.forward * speed);
        }
    }


    void OnTriggerEnter(Collider other) {
        if (other.tag == "bullet") {
            print("Bullet");
        }

        if (other.tag == "rock"){
            print("Rock");
            Destroy(other.gameObject);
        }

        else {
            Destroy(this.gameObject);
        }

    }
}
