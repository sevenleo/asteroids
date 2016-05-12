using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class moves : MonoBehaviour {

    public Light turbo;
    public Camera cam;
    bool turboTF = false;
    public float speed = 0.01f;
    public float rot = 1f;
    bool fixedrotation = false;
    

    void Start () {
	
	}
	
	void Update () {
        if (Input.GetKey(KeyCode.T))
        {
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


        if (Input.GetKey(KeyCode.CapsLock))        {
            fixedrotation = !fixedrotation;
        }

        if (fixedrotation)        {
            if (Input.GetKey(KeyCode.A))
                this.transform.rotation *= Quaternion.Euler(0, 0, rot);

            if (Input.GetKey(KeyCode.D))
                this.transform.rotation *= Quaternion.Euler(0, 0, -rot);
        }
        

        if (Input.GetKey(KeyCode.E) || Input.GetKey(KeyCode.RightArrow))
            this.transform.rotation *= Quaternion.Euler(0, rot, 0);

        if (Input.GetKey(KeyCode.Q) || Input.GetKey(KeyCode.LeftArrow))
            this.transform.rotation *= Quaternion.Euler(0, -rot, 0);

        if (Input.GetKey(KeyCode.W))
            this.transform.rotation *= Quaternion.Euler(rot, 0, 0);

        if (Input.GetKey(KeyCode.S))
            this.transform.rotation *= Quaternion.Euler(-rot, 0, 0);


        if (Input.GetKey(KeyCode.UpArrow))        {
            this.transform.position += speed * transform.up;

        }

        if (Input.GetKey(KeyCode.DownArrow))        {
            this.transform.position -= speed * transform.up;
        }


        if (Input.GetKey(KeyCode.LeftShift)){
            this.transform.position += speed * transform.forward;
            if (Input.GetKeyDown(KeyCode.LeftShift)) speed += 0.5f;

        }

        if (Input.GetKey(KeyCode.LeftControl)) {
            this.transform.position -= speed * transform.forward;
            if (Input.GetKeyDown(KeyCode.LeftControl)) speed += 0.5f;
            turbo.GetComponent<Light>().color = Color.red;
        }
            

    }
    
    void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Stone_5")
        {
            SceneManager.LoadScene("scene1");
        }
        


    }
}
