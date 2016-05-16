using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class move_onlyship : MonoBehaviour {
    public float rot = 1f;
    // Use this for initialization
    void Start () {
       

    }

    // Update is called once per frame
    void Update () {
        if (Input.GetKey(KeyCode.A))
            this.transform.rotation *= Quaternion.Euler(0, 0, -rot);

        if (Input.GetKey(KeyCode.D))
            this.transform.rotation *= Quaternion.Euler(0, 0, rot);

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
