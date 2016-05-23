using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class move_onlyship : MonoBehaviour {
    public GameObject trail;
    public float rot = 3f;
    private float ControlTime;
    private float ControlTimeRate = 1f;
    bool fixedrotation = true;

    // Use this for initialization
    void Start () {
        ControlTime = Time.time;

    }

    // Update is called once per frame
    void Update () {

        if (Input.GetKey(KeyCode.CapsLock) && Time.time > ControlTime)
        {
            ControlTime = Time.time + ControlTimeRate;
            fixedrotation = !fixedrotation;
        }

        if (Input.GetKey(KeyCode.A))
            this.transform.rotation *= Quaternion.Euler(0, 0, -rot);

        if (Input.GetKey(KeyCode.D))
            this.transform.rotation *= Quaternion.Euler(0, 0, rot);
   


    }

    void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "rock"  || other.tag == "terrain" || other.tag == "sun" || other.tag == "star")
        {
            //Destroy(this.gameObject);
            SceneManager.LoadScene("gameover");
        }

        if (other.tag == "universe")
        {
            GameObject.FindGameObjectWithTag("canvas").GetComponent<Text>().text = "ENTRANDO";
        }
    }


    void OnTriggerExit(Collider other)
    {
        if (other.tag == "universe" )
        {
            GameObject.FindGameObjectWithTag("canvas").GetComponent<Text>().text = "SAINDO";

            ControlTime = Time.time + ControlTimeRate;
            GameObject.FindGameObjectWithTag("MainCamera").transform.RotateAround(GameObject.FindGameObjectWithTag("MainCamera").transform.position, Vector3.up, 180);

            

        }
    }

       
}
