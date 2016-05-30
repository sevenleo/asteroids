using UnityEngine;
using CnControls;
using System.Collections;


public class Shoot : MonoBehaviour {
	public Rigidbody bullet;
    public GameObject explosion;


    public float shootspeed = 1.0f;
    private float nextFire;
    


    // Use this for initialization
    void Start () {
        
    }

    // Update is called once per frame
    void Update () {

        if (PlayerPrefs.GetString("touch") == "off")
        {
            if ((Input.GetKey(KeyCode.Space) || Input.GetMouseButton(0)  ) && Time.time > nextFire)
            {
                shoot();

            }
        }
        else
        {
            if (CnInputManager.GetButtonDown("shootback")) shootback();

            if (CnInputManager.GetButton("shoot"))
            {

                
                shoot();
            }
            

            if ( (Input.GetKey(KeyCode.Space) ) && Time.time > nextFire)
            {
                shoot();

            }
        }


        if ((Input.GetKey(KeyCode.B) ) && Time.time > nextFire)
        {
            shootback();
        }

    }

     public void shoot()
    {
        
            nextFire = Time.time + levels.fireRate;
            Rigidbody bulletinstace = Instantiate(bullet, this.transform.position, this.transform.rotation) as Rigidbody;

            bulletinstace.AddForce(transform.forward * shootspeed * -1, ForceMode.Impulse);
       
    }


    public void shootback()
    {
        nextFire = Time.time + levels.fireRate;
        Rigidbody bulletinstace = Instantiate(bullet, this.transform.position, this.transform.rotation) as Rigidbody;

        bulletinstace.AddForce(transform.forward * shootspeed, ForceMode.Impulse);
    }

    }
