using UnityEngine;
using System.Collections;


public class Shoot : MonoBehaviour {
	public Rigidbody bullet;
    public GameObject explosion;


    public float shootspeed = 1.0f;
    private float nextFire;
    private float fireRate;


    // Use this for initialization
    void Start () {
        fireRate = levels.fireRate;
    }

    // Update is called once per frame
    void Update () {

    
        if ( (Input.GetKey(KeyCode.Space)  || Input.GetMouseButton(0) ) && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Rigidbody bulletinstace = Instantiate(bullet, this.transform.position , this.transform.rotation) as Rigidbody;
           
            bulletinstace.AddForce(transform.forward * shootspeed *-1, ForceMode.Impulse);
        }


        if ((Input.GetKey(KeyCode.B) ) && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Rigidbody bulletinstace = Instantiate(bullet, this.transform.position, this.transform.rotation) as Rigidbody;

            bulletinstace.AddForce(transform.forward * shootspeed, ForceMode.Impulse);
        }

    }

     public void shoot()
    {
        
            nextFire = Time.time + fireRate;
            Rigidbody bulletinstace = Instantiate(bullet, this.transform.position, this.transform.rotation) as Rigidbody;

            bulletinstace.AddForce(transform.forward * shootspeed * -1, ForceMode.Impulse);
       
    }


}
