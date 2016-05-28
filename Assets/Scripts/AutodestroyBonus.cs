using UnityEngine;
using System.Collections;

public class AutodestroyBonus : MonoBehaviour {


    float ControlTime;
    float ControlTimeRate = 20f;
    
    void Start () {
        ControlTime = Time.time + ControlTimeRate;

    }
	
	
	void Update () {

        if (Time.time > ControlTime) Destroy(this.gameObject);
	}
}
