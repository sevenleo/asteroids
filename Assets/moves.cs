using UnityEngine;
using System.Collections;

public class moves : MonoBehaviour {

    public float speed = 0.1f;
    public float rot = 1f;
    

    void Start () {
	
	}
	
	void Update () {

        if (Input.GetKey(KeyCode.A))
            this.transform.rotation *= Quaternion.Euler(0, 0, rot);

        if (Input.GetKey(KeyCode.D))
            this.transform.rotation *= Quaternion.Euler(0, 0, -rot);

        if (Input.GetKey(KeyCode.E) || Input.GetKey(KeyCode.RightArrow))
            this.transform.rotation *= Quaternion.Euler(0, rot, 0);

        if (Input.GetKey(KeyCode.Q) || Input.GetKey(KeyCode.LeftArrow))
            this.transform.rotation *= Quaternion.Euler(0, -rot, 0);

        if (Input.GetKey(KeyCode.UpArrow))
            this.transform.rotation *= Quaternion.Euler(rot, 0, 0);

        if (Input.GetKey(KeyCode.DownArrow))
            this.transform.rotation *= Quaternion.Euler(-rot, 0, 0);


        if (Input.GetKey(KeyCode.W))        {
            this.transform.position += speed * transform.up;

        }

        if (Input.GetKey(KeyCode.S))        {
            this.transform.position -= speed * transform.up;
        }


        if (Input.GetKey(KeyCode.LeftShift)){
            this.transform.position += speed * transform.forward;
            if (Input.GetKeyDown(KeyCode.LeftShift)) speed += 0.5f;

        }

        if (Input.GetKey(KeyCode.LeftControl)) {
            this.transform.position -= speed * transform.forward;
            if (Input.GetKeyDown(KeyCode.LeftControl)) speed += 0.5f;
        }
            

    }
}
