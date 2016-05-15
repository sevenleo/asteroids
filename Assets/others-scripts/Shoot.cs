using UnityEngine;
using System.Collections;


public class Shoot : MonoBehaviour {
	public Rigidbody bullet;
   // public Rigidbody ship;
    public float shootspeed = 10000.0f;
    
    // Use this for initialization
    void Start () {
        //Physics.IgnoreCollision(bullet.GetComponent<Collider>(), ship.GetComponent<Collider>());

    }

    // Update is called once per frame
    void Update () {

		if (Input.GetKey(KeyCode.Space)  || Input.GetMouseButton(1))  {
            
            Rigidbody bulletinstace = Instantiate(bullet, this.transform.position, this.transform.rotation) as Rigidbody;
            //bulletinstace.velocity = transform.forward * shootspeed*-1;
            bulletinstace.AddForce(transform.forward * shootspeed *-1, ForceMode.VelocityChange);
        }
    }


}
