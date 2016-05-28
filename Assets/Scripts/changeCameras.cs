using UnityEngine;
using System.Collections;

public class changeCameras : MonoBehaviour {

    public Camera cam_3rd;
    public Camera cam_1st;
    public Camera cam_top;
    public Camera cam_back;
    public Shoot shoot;

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
            st_3rd();

        }

        if (!cam_back.enabled && !cam_1st.enabled && Input.GetKeyDown(KeyCode.V))
        {
            top_3rd();
        }


        if (!cam_top.enabled && !cam_1st.enabled)
        {

            if (Input.GetKeyDown(KeyCode.R))
            {
                lookbackin();
            }

            else if (Input.GetKeyUp(KeyCode.R))
            {
                lookbackout();
            }
        }
    }

    public void top_3rd() {
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


    public void st_3rd()
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


    public void lookbackin()
    {
        cam_3rd.enabled = false;
        cam_back.enabled = true;
        GameObject.FindGameObjectWithTag("aim").GetComponent<Renderer>().enabled = false;
    }


    public void lookbackout() {
        cam_back.enabled = false;
        cam_3rd.enabled = true;
        GameObject.FindGameObjectWithTag("aim").GetComponent<Renderer>().enabled = true;
    }
}
