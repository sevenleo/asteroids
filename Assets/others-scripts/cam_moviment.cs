using UnityEngine;
using System.Collections;

public class cam_moviment : MonoBehaviour {

    public float speed = 1f;
 
    void Start()
    {
    }


    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Keypad6))
        {
            transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
        }
        if (Input.GetKey(KeyCode.Keypad4))
        {
            transform.Translate(new Vector3(-speed * Time.deltaTime, 0, 0));
        }
        if (Input.GetKey(KeyCode.Keypad2))
        {
            transform.Translate(new Vector3(0, -speed * Time.deltaTime, 0));
        }
        if (Input.GetKey(KeyCode.Keypad8))
        {
            transform.Translate(new Vector3(0, speed * Time.deltaTime, 0));
        }
    }
}
