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
        GameObject.FindGameObjectWithTag("ship2").GetComponent<Renderer>().enabled = false;
        GameObject.FindGameObjectWithTag("ship2trail").GetComponent<Renderer>().enabled = false;
        GameObject.FindGameObjectWithTag("ship2cannon").GetComponent<Renderer>().enabled = false;

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

        if (other.gameObject.tag.EndsWith("Bonus"))
        {
            GameObject.FindGameObjectWithTag("Bonus").GetComponent<AudioSource>().Play();
        }

        if (other.tag == "rock"  || other.tag == "terrain" || other.tag == "sun" || other.tag == "star")
        {
            //Destroy(this.gameObject);
            if (levels.lifes > 1) {
                levels.lifes--;
                Destroy(other.gameObject);

                if (GameObject.FindGameObjectWithTag("ship2").GetComponent<Renderer>().enabled)
                {
                    GameObject.FindGameObjectWithTag("ship").GetComponent<Renderer>().enabled = true;
                    GameObject.FindGameObjectWithTag("ship2").GetComponent<Renderer>().enabled = false;
                    GameObject.FindGameObjectWithTag("ship2trail").GetComponent<Renderer>().enabled = false;
                    GameObject.FindGameObjectWithTag("ship2cannon").GetComponent<Renderer>().enabled = false;
                }

            }
            else SceneManager.LoadScene("gameover");
        }
        else if (other.tag == "universe")
        {
            goback = false;
        }
        

        


        else if (other.tag == "LifeBonus") {
            Destroy(other.gameObject);
            levels.lifes++;
        }
        else if (other.tag == "SpeedBonus")  {
            Destroy(other.gameObject);
            levels.turbo = true;
        }
        else if (other.tag == "TimeBonus")        {
            Destroy(other.gameObject);
            PlayerPrefs.SetString("level", "easy");   
        }
        else if (other.tag == "DeadBonus")        {
            Destroy(other.gameObject);
            PlayerPrefs.SetString("level", "hard");
            levels.lifes = 1;
        }
        else if (other.tag == "FireBonus")        {
            Destroy(other.gameObject);
            levels.fireRate *= 2f;
        }
        else if (other.tag == "StarBonus")        {
            Destroy(other.gameObject);
            GameObject.FindGameObjectWithTag("ship").GetComponent<Renderer>().enabled = false;
            GameObject.FindGameObjectWithTag("ship2").GetComponent<Renderer>().enabled = true;
            GameObject.FindGameObjectWithTag("ship2trail").GetComponent<Renderer>().enabled = true;
            GameObject.FindGameObjectWithTag("ship2cannon").GetComponent<Renderer>().enabled = true;
            levels.fireRate *= 2f;
            levels.turbo = true;
            levels.lifes++;
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
