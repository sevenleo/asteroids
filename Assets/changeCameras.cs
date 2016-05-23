using UnityEngine;
using System.Collections;

public class changeCameras : MonoBehaviour {

    public Camera cam_3rd;
    public Camera cam_1st;
    public Camera cam_top;

    void Start()
    {
        cam_3rd.enabled = true;
        cam_1st.enabled = false;
        cam_top.enabled = false;
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.C))
        {
            cam_3rd.enabled = !cam_3rd.enabled;
            cam_1st.enabled = !cam_1st.enabled;
            if (cam_1st.enabled)
            {
                GameObject.FindGameObjectWithTag("aim").GetComponent<Renderer>().enabled = false;
            }
            else if (cam_3rd.enabled)
            {
                GameObject.FindGameObjectWithTag("aim").GetComponent<Renderer>().enabled = true;
            }
        }

        if (!cam_1st.enabled && Input.GetKeyDown(KeyCode.V))
        {
            cam_3rd.enabled = !cam_3rd.enabled;
            cam_top.enabled = !cam_top.enabled;
            if (cam_top.enabled)
            {
                GameObject.FindGameObjectWithTag("aim").GetComponent<Renderer>().enabled = false;
            }
            else if (cam_3rd.enabled)
            {
                GameObject.FindGameObjectWithTag("aim").GetComponent<Renderer>().enabled = true;
            }
        }

    }
}
