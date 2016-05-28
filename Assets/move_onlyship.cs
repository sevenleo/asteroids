using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class move_onlyship : MonoBehaviour {
    bool goback = false;
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

        if (goback)        {
            //GameObject.FindGameObjectWithTag("canvas").GetComponent<Text>().text = "*Volte!";
            GameObject.FindGameObjectWithTag("pointer").transform.LookAt(Vector3.zero);
            GameObject.FindGameObjectWithTag("pointer").transform.rotation *= Quaternion.Euler(90, 0, 0);
        }

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
            if (levels.lifes > 0) { levels.lifes--; }
            else SceneManager.LoadScene("gameover");
        }

        if (other.tag == "universe")
        {
            goback = false;
        }
    }


    void OnTriggerExit(Collider other)
    {
        if (other.tag == "universe" )
        {
            GameObject.FindGameObjectWithTag("canvas").GetComponent<Text>().text = "SAINDO DA ZONA SEGURA";
            goback = true;
            ControlTime = Time.time + ControlTimeRate;
            GameObject.FindGameObjectWithTag("MainCamera").transform.RotateAround(GameObject.FindGameObjectWithTag("MainCamera").transform.position, Vector3.up, 180);

            

        }
    }

       
}
