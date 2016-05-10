using UnityEngine;
using System.Collections;

public class moveSpeed : MonoBehaviour {

    public float speed = 0.1f;
    public GameObject ship;
   
    Vector3 impulse;

    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {


        impulse = new Vector3(0, 0, speed);

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
