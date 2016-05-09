using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {
	public GameObject bullet;

	// Use this for initialization
	void Start () {
	    bullet.transform.position=this.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space)){
			bullet.transform.position=this.transform.position;
            bullet.GetComponent<Rigidbody>().velocity = new Vector3(0,0,100);// transform.forward;

        }
	}
}
