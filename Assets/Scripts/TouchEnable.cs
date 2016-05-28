using UnityEngine;
using System.Collections;

public class TouchEnable : MonoBehaviour {
    public GameObject touchscreen;
    
    // Use this for initialization
    void Start () {
        if (PlayerPrefs.GetString("touch") == "on")
        {
            touchscreen.SetActive(true);
            levels.autoaccelerate = true;
        }
        else
        {
            touchscreen.SetActive(false);
            levels.autoaccelerate = false;
        }

    }
	
}
