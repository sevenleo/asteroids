using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class moves : MonoBehaviour {

    
    public GameObject ship;
    public GameObject shipTrailGo;
    public GameObject shipTrailBack;
    //this.gameObject.GetComponent<Animation>().Play("goBack");

    public Light turbo;

    bool turboTF = false;
    bool autoaccelerate = false;
    bool fixedrotation = false;
    public float speed = 0.01f;
    public float rot = 1f;
    private float ControlTime;
    private float ControlTimeRate =0.1f;


    void Start () {
        ControlTime = Time.time;

    }

    void Update() {

        if (Input.GetKey(KeyCode.R) && Time.time > ControlTime)
        {
            ControlTime = Time.time + ControlTimeRate;
            GameObject.FindGameObjectWithTag("MainCamera").transform.RotateAround(GameObject.FindGameObjectWithTag("MainCamera").transform.position, Vector3.up, 180);

        }
        if (Input.GetKey(KeyCode.T) && Time.time > ControlTime)
        {
            ControlTime = Time.time + ControlTimeRate;
            turboTF = !turboTF;

        }

        if (Input.GetKey(KeyCode.Z) && Time.time > ControlTime)
        {
            ControlTime = Time.time + ControlTimeRate;
            autoaccelerate = !autoaccelerate;
        }
        if (autoaccelerate)
        {
            ship.GetComponent<AudioSource>().volume = 100;
            shipTrailGo.GetComponent<Renderer>().enabled = true;
            this.transform.position += speed * transform.forward;

        }
        if (turboTF) {
            turbo.GetComponent<Light>().color = Color.red;
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
            ship.GetComponent<AudioSource>().volume = 100;
            shipTrailGo.GetComponent<Renderer>().enabled = true;

        }

        else if (Input.GetKey(KeyCode.LeftControl))
        {
            this.transform.position -= speed * transform.forward;
            shipTrailBack.GetComponent<Renderer>().enabled = true;
            ship.GetComponent<AudioSource>().volume = 100;
            
        }

        else if (Time.time > ControlTime)
        {
            ControlTime = Time.time + ControlTimeRate;
            ship.GetComponent<AudioSource>().volume = 0;
            shipTrailGo.GetComponent<Renderer>().enabled = false;
            shipTrailBack.GetComponent<Renderer>().enabled = false;
        }


   
    }

    void OnTriggerExit(Collider other)
    {

    }

}
