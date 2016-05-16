using UnityEngine;
using System.Collections;

public class MouseMove : MonoBehaviour {

    float speed = 150.0f;
    Vector3 center;

    // Use this for initialization
    void Start () {
        center = new Vector3(Screen.width / 2, Screen.height / 2, 0);

    }
	
	// Update is called once per frame
	void Update () {
        Vector3 delta = (Input.mousePosition - center) / Screen.height;

        if (Input.GetMouseButton(1)) {
            transform.Rotate(-delta.y * Time.deltaTime * speed, delta.x * Time.deltaTime * speed, 0);
        }
    }
}
