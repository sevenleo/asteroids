using UnityEngine;
using System.Collections;

public class ship_moviment : MonoBehaviour {


    public float speed = 1.0f;
    public float turnSpeed = 0.7f;


    void Start()
    {
        GetComponent<Rigidbody>().useGravity = false;
    }


    void FixedUpdate()
    {
        if (Input.GetButton("Jump"))
        {
            //Spacebar by default will make it move forward 
            GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * speed);
        }


        // W key or the up arrow to turn upwards, S or the down arrow to turn downwards. 
        GetComponent<Rigidbody>().AddRelativeTorque((Input.GetAxis("Vertical")) * turnSpeed, 0, 0);

        // A or left arrow to turn left, D or right arrow to turn right. 
        GetComponent<Rigidbody>().AddRelativeTorque(0, (Input.GetAxis("Horizontal")) * turnSpeed, 0);

    }
}
