using UnityEngine;
using System.Collections;


public class Shoot : MonoBehaviour {
	public Rigidbody bullet;
   // public Rigidbody ship;
    public float shootspeed = 1.0f;
    private float nextFire;
    private float fireRate = 0.1f;


    // Use this for initialization
    void Start () {
    }

    // Update is called once per frame
    void Update () {

		if ( (Input.GetKey(KeyCode.Space)  || Input.GetMouseButton(1) ) && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Rigidbody bulletinstace = Instantiate(bullet, this.transform.position, this.transform.rotation) as Rigidbody;
           
            bulletinstace.AddForce(transform.forward * shootspeed *-1, ForceMode.Impulse);
        }
    }


}
