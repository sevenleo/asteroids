using UnityEngine;
using System.Collections;


public class Shoot : MonoBehaviour {
	public Rigidbody bullet;
   // public Rigidbody ship;
    public float shootspeed = 1000.0f;
    
    // Use this for initialization
    void Start () {
        //Physics.IgnoreCollision(bullet.GetComponent<Collider>(), ship.GetComponent<Collider>());
        
    }

    // Update is called once per frame
    void Update () {

		if (Input.GetKeyUp(KeyCode.Space)  || Input.GetMouseButtonUp(1))  {
            Rigidbody bulletinstace = Instantiate(bullet, GameObject.FindWithTag("ship").transform.position, GameObject.FindWithTag("ship").transform.rotation) as Rigidbody;
            bulletinstace.velocity = transform.forward * shootspeed;
            
            Destroy(bulletinstace, 5);
        }
    }


}
