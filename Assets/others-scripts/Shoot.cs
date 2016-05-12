using UnityEngine;
using System.Collections;


public class Shoot : MonoBehaviour {
	public Rigidbody bullet;
    public Rigidbody ship;
    public float shootspeed = 10.0f;
    
    // Use this for initialization
    void Start () {
        Physics.IgnoreCollision(bullet.GetComponent<Collider>(), ship.GetComponent<Collider>());
    }

    // Update is called once per frame
    void Update () {

		if (Input.GetKeyDown(KeyCode.Space)  || Input.GetMouseButtonDown(1))  {
            Rigidbody bulletinstace = Instantiate(bullet, ship.transform.position, ship.transform.rotation) as Rigidbody;
            bulletinstace.velocity = transform.forward * shootspeed;
        }
    }


    void OnTriggerEnter(Collider other) {
      
        Destroy(other.gameObject);

        if (other.tag == "rock"){
            
        }

        

    }
}
