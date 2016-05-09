using UnityEngine;
using System.Collections;

public class moves : MonoBehaviour {

    float turnspeed = 5.1f;
    float speed = 5.0f;
    float trueSpeed = 0.0f;
    float strafeSpeed = 5.0f;
    public GameObject ship;
    public GameObject camera;


    void Start () {
	
	}
	
	void Update () {
        //camera.GetComponent<Rigidbody>().AddRelativeTorque((Input.GetAxis("Vertical")) * turnspeed, 0, 0);
        //camera.GetComponent<Rigidbody>().AddRelativeTorque(0, (Input.GetAxis("Horizontal")) * turnspeed, 0);



        Vector3 strafe = new Vector3(Input.GetAxis("Horizontal") * strafeSpeed * Time.deltaTime, Input.GetAxis("Vertical") * strafeSpeed * Time.deltaTime, 0);
        float roll = Input.GetAxis("Roll");
        float pitch = Input.GetAxis("Pitch");
        float yaw = Input.GetAxis("Yaw");
        float power = Input.GetAxis("Power");
       
            
        
        //Truespeed controls

        if (trueSpeed < 10 && trueSpeed > -3) trueSpeed += power;
        if (trueSpeed > 10) trueSpeed = 9.99f;
        if (trueSpeed < -3) trueSpeed = -2.99f;
        if (Input.GetKey("backspace")) trueSpeed = 0;

        //freio brusco
        if (Input.GetKeyDown(KeyCode.LeftShift) || Input.GetKeyDown(KeyCode.RightShift)) { 
             GetComponent<Rigidbody>().velocity = Vector3.zero;
             GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
         }

        GetComponent<Rigidbody>().AddRelativeTorque(pitch * turnspeed * Time.deltaTime, yaw * turnspeed * Time.deltaTime, roll * turnspeed * Time.deltaTime);
        GetComponent<Rigidbody>().AddRelativeForce(0, 0, trueSpeed * speed * Time.deltaTime);
        GetComponent<Rigidbody>().AddRelativeForce(strafe);
      

    }
}
