using UnityEngine;
using System.Collections;


public class Shoot : MonoBehaviour {
	public Rigidbody bullet;
    public float speed = 100;
    
    // Use this for initialization
    void Start () {
	    //bullet.transform.position=this.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space)  || Input.GetMouseButtonDown(0))        {
            bullet.transform.position=this.transform.position;
            bullet.GetComponent<Rigidbody>().velocity = new Vector3(0,0,speed);// transform.forward;
            bullet.AddForce(transform.position * speed);
           /* Vector3 sizeship = new Vector3(0, 0, 1);
            Rigidbody bulletinstace = Instantiate(bullet, transform.position+ sizeship, transform.rotation) as Rigidbody;
            bulletinstace.velocity = new Vector3(0, 0, speed);
            bulletinstace.AddForce(transform.forward * speed);*/
        }
    }
}
