using UnityEngine;
using CnControls;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class moves : MonoBehaviour {

    
    public GameObject ship;
    public GameObject shipTrailGo;
    public GameObject shipTrailBack;

    public Light turbo;

    bool turboTF = false;
    bool fixedrotation = false;
    public float speed = 0.01f;
    public float rot = 1f;
    private float ControlTime;
    private float ControlTimeRate =0.1f;
    private float turboStarted;


    void Start () {
        ControlTime = Time.time;

    }

    void Update() {

        //////////////// MOVIMENTOS ////////////////

        
        if (Input.GetKey(KeyCode.A) )
            this.transform.rotation *= Quaternion.Euler(0, -rot, 0);

        else if (Input.GetKey(KeyCode.D))
            this.transform.rotation *= Quaternion.Euler(0, rot, 0);

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

        //////////////// ROTACAO TRAVADA OU NAO ////////////////
        if (Input.GetKey(KeyCode.CapsLock) && Time.time > ControlTime)
        {
            ControlTime = Time.time + ControlTimeRate;
            fixedrotation = !fixedrotation;
        }

        if (fixedrotation)
        {
            if (Input.GetKey(KeyCode.E) || Input.GetKey(KeyCode.RightArrow))
                
                this.transform.rotation *= Quaternion.Euler(0, 0, rot);

            else if (Input.GetKey(KeyCode.Q) || Input.GetKey(KeyCode.LeftArrow))
                this.transform.rotation *= Quaternion.Euler(0, 0, -rot);
        }

        ////////////////RODAR 180////////////////
        /*if (Input.GetKey(KeyCode.R) && Time.time > ControlTime)
        {
            ControlTime = Time.time + ControlTimeRate;
            GameObject.FindGameObjectWithTag("MainCamera").transform.RotateAround(GameObject.FindGameObjectWithTag("MainCamera").transform.position, Vector3.up, 180);
        }
        */


        //////////////// ACELERA E RÉ ////////////////
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



        ////////////////ACELADOR AUTOMATICO////////////////
        if (Input.GetKey(KeyCode.Z) && (Time.time > ControlTime) )
        {
            ControlTime = Time.time + ControlTimeRate;
            levels.autoaccelerate = !levels.autoaccelerate;
        }
        if (levels.autoaccelerate)
        {
            ship.GetComponent<AudioSource>().volume = 100;
            shipTrailGo.GetComponent<Renderer>().enabled = true;
            this.transform.position += speed * transform.forward;

        }

        ////////////////TURBO + LUZES////////////////
        if (levels.turbo)
        {
            turboStarted = Time.time;
            turboTF = true; 
        }
        else turboTF = false;


        if (turboTF)
        {
            turbo.GetComponent<Light>().color = Color.red;
            speed = 3.5f;
            rot = 1.5f;
            if (Time.time > turboStarted + 10f) levels.turbo = false;
        }
        else
        {
            turbo.GetComponent<Light>().color = Color.white;
            speed = 0.8f;
            rot = 0.6f;
        }


    }

    public void FixedUpdate()
    {
        float adjust = 0.3f;
        float v = CnInputManager.GetAxis("Vertical2");
        float h = CnInputManager.GetAxis("Horizontal2");
        this.transform.rotation *= Quaternion.Euler(-v *adjust* rot, 0, 0);
        this.transform.rotation *= Quaternion.Euler(0, h * adjust * rot, 0);

    }

    ////////////////TOUCHSCREEN////////////////
    float touchadjust = 20;
    public void touchleft() { this.transform.rotation *= Quaternion.Euler(0, touchadjust *- rot, 0); }
    public void touchright() { this.transform.rotation *= Quaternion.Euler(0, touchadjust * rot, 0); }
    public void touchup()
    {
        this.transform.rotation *= Quaternion.Euler(touchadjust * rot, 0, 0);
    }
    public void touchdown()
    {
        this.transform.rotation *= Quaternion.Euler(touchadjust * -rot, 0, 0);
    }

}
