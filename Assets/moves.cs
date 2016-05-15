using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class moves : MonoBehaviour {

    public GameObject ship;
    public Light turbo;
    private float ControlTime;
    private float ControlTimeRate = 0.1f;
    bool turboTF = false;
    public float speed = 0.01f;
    public float rot = 1f;
    bool fixedrotation = false;
    

    void Start () {
        GetComponent<Rigidbody>().sleepThreshold = 1f;

    }
	
	void Update () {
        if (Input.GetKey(KeyCode.T) && Time.time > ControlTime)
        {
            ControlTime = Time.time + ControlTimeRate;
            turboTF = !turboTF;
            
        }

        if (turboTF) {
            turbo.GetComponent<Light>().color = Color.green;
            speed = 3.5f;
            rot = 1.5f;
        }
        else
        {
            turbo.GetComponent<Light>().color = Color.white;
            speed = 0.8f;
            rot = 0.6f;
        }


        if (Input.GetKey(KeyCode.CapsLock) && Time.time > ControlTime)
        {
            ControlTime = Time.time + ControlTimeRate;
            fixedrotation = !fixedrotation;
        }

        if (fixedrotation)        {
            if (Input.GetKey(KeyCode.A))
                this.transform.rotation *= Quaternion.Euler(0, 0, rot);

            else if (Input.GetKey(KeyCode.D))
                this.transform.rotation *= Quaternion.Euler(0, 0, -rot);
        }
        

        if (Input.GetKey(KeyCode.E) || Input.GetKey(KeyCode.RightArrow))
            this.transform.rotation *= Quaternion.Euler(0, rot, 0);

        else if (Input.GetKey(KeyCode.Q) || Input.GetKey(KeyCode.LeftArrow))
            this.transform.rotation *= Quaternion.Euler(0, -rot, 0);

        if (Input.GetKey(KeyCode.W))
            this.transform.rotation *= Quaternion.Euler(rot, 0, 0);

        else if (Input.GetKey(KeyCode.S))
            this.transform.rotation *= Quaternion.Euler(-rot, 0, 0);


        if (Input.GetKey(KeyCode.UpArrow))        {
            this.transform.position += speed * transform.up;

        }

        else if (Input.GetKey(KeyCode.DownArrow))        {
            this.transform.position -= speed * transform.up;
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            this.transform.position += speed * transform.forward;
            //this.GetComponent<Rigidbody>().AddForce(transform.forward, ForceMode.Force);

        }

        else if (Input.GetKey(KeyCode.LeftControl))
        {
            this.transform.position -= speed * transform.forward;
            turbo.GetComponent<Light>().color = Color.red;
            //this.GetComponent<Rigidbody>().AddForce(-transform.forward, ForceMode.Force);

        }
        else
        {
            GetComponent<Rigidbody>().Sleep();
        }

    }
    

}
