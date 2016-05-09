using UnityEngine;
using System.Collections;

public class MouseMove : MonoBehaviour {

    float noTurn = 0.1f; // Extent of the no-turn zone as a fraction of Screen.height;
    float factor = 150.0f;
    Vector3 center;

	// Use this for initialization
	void Start () {
        center = new Vector3(Screen.width / 2, Screen.height / 2, 0);

    }
	
	// Update is called once per frame
	void Update () {
        float power = Input.GetAxis("Mouse ScrollWheel");
        Vector3 delta = (Input.mousePosition - center) / Screen.height;
        Debug.Log(delta);
        if (Input.GetMouseButton(1))
        {

            if (delta.y > noTurn)
                transform.Rotate(-(delta.y - noTurn) * Time.deltaTime * factor, 0, 0);
            if (delta.y < -noTurn)
                transform.Rotate(-(delta.y + noTurn) * Time.deltaTime * factor, 0, 0);
            if (delta.x > noTurn)
                transform.Rotate(0, (delta.x - noTurn) * Time.deltaTime * factor, 0);
            if (delta.x < -noTurn)
                transform.Rotate(0, (delta.x + noTurn) * Time.deltaTime * factor, 0);
        }
    }
}
