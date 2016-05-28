using UnityEngine;
using System.Collections;

public class changeCameras : MonoBehaviour {

    public Camera cam_3rd;
    public Camera cam_1st;
    public Camera cam_top;
    public Camera cam_back;

    void Start()
    {
        cam_3rd.enabled = true;
        cam_1st.enabled = false;
        cam_top.enabled = false;
        cam_back.enabled = false;
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

        if (!cam_back.enabled && !cam_1st.enabled && Input.GetKeyDown(KeyCode.V))
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


        if (!cam_top.enabled && !cam_1st.enabled)
        {

            if (Input.GetKeyDown(KeyCode.R))
            {
                cam_3rd.enabled = false;
                cam_back.enabled = true;
                GameObject.FindGameObjectWithTag("aim").GetComponent<Renderer>().enabled = false;
            }

            else if (Input.GetKeyUp(KeyCode.R))
            {
                cam_back.enabled = false;
                cam_3rd.enabled = true;
                GameObject.FindGameObjectWithTag("aim").GetComponent<Renderer>().enabled = true;
            }
        }




    }
}
