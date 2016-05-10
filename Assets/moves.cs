using UnityEngine;
using System.Collections;

public class moves : MonoBehaviour {


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

        if (Input.GetKey(KeyCode.W))
            this.transform.rotation *= Quaternion.Euler(rot, 0, 0);

        if (Input.GetKey(KeyCode.S))
            this.transform.rotation *= Quaternion.Euler(-rot, 0, 0);

    }
}
