using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class move_onlyship : MonoBehaviour {
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

        if ((Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.LeftControl)))
        {
            
            GetComponent<AudioSource>().volume = 100;
        }
        else if (Time.time > ControlTime)
        {
            ControlTime = Time.time + ControlTimeRate;
            GetComponent<AudioSource>().volume = 0;
        }
        //GameObject.FindGameObjectWithTag("canvas").GetComponent<Text>().text = "Asteroids 3D\n" + this.transform.position;


    }

    void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "rock" || other.gameObject.name =="rock")
        {
            //Destroy(this.gameObject);
            SceneManager.LoadScene("gameover");
        }

        if (other.tag == "universe" || other.gameObject.name == "universe")
        {
            
        }

        }
}
