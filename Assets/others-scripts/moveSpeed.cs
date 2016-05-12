using UnityEngine;
using System.Collections;

public class moveSpeed : MonoBehaviour {

    public float speed = 0.1f;
    public GameObject ship;
   
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {


        if (Input.GetKey(KeyCode.LeftControl)) {
            //this.transform.position -= speed * transform.forward;
            //ship.GetComponent<Rigidbody>().AddForce(-impulse);
            //speed -= 5; 
            //ship.transform.position -= impulse;
        }
            

        if (Input.GetKey(KeyCode.LeftShift)) {
            //this.transform.position += speed * transform.forward;
            //ship.GetComponent<Rigidbody>().AddForce(impulse);
            // speed += 5;
            //ship.transform.position += impulse;
        }
           
    }
}
