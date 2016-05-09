using UnityEngine;
using System.Collections;

public class MoveCamera : MonoBehaviour {
	public float velocidade = 0.1f;
	public float rot = 1f;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		 if (Input.GetKey(KeyCode.W))
			this.transform.position += velocidade*transform.forward;
		
		if (Input.GetKey(KeyCode.S))
			this.transform.position -= velocidade*transform.forward;
		
		if (Input.GetKey(KeyCode.D))
			this.transform.rotation *= Quaternion.Euler(0,rot,0);
		
		if (Input.GetKey(KeyCode.A))
			this.transform.rotation *= Quaternion.Euler(0,-rot,0);
	}
}
