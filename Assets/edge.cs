using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class edge : MonoBehaviour
{
    bool goback = false;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (goback)
        {
            GameObject.FindGameObjectWithTag("canvas").GetComponent<Text>().text = "Volte!";
            GameObject.FindGameObjectWithTag("pointer").transform.LookAt(this.transform.position);
            GameObject.FindGameObjectWithTag("pointer").transform.rotation *= Quaternion.Euler(90, 0, 0);
        }
    }

    void OnTriggerExit(Collider other)
    {
        goback = true;

    }
    void OnTriggerEnter(Collider other)
    {
        goback = false;

    }
}
