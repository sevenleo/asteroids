using UnityEngine;
using System.Collections;

public class moveSpeed : MonoBehaviour {

    public float velocidade = 0.001f;
    public GameObject ship;
    public GameObject camera;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.LeftControl))
            //this.transform.position -= velocidade * transform.forward;
            ship.AddForce(transform.forward * velocidade);

        if (Input.GetKey(KeyCode.LeftShift))
            //this.transform.position += velocidade * transform.forward;
            ship.AddForce(-1 * transform.forward * velocidade);
    }
}
