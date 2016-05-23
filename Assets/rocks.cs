using UnityEngine;
using System.Collections;

public class rocks : MonoBehaviour {
    
  
    public static int destroyeds { get; set; }
    public static int stones { get; set; }
    public static int quantidade { get; set; }

    
    public GameObject stone;
    GameObject[] rock;
    double nrocks;
    private float ControlTime;
    private float ControlTimeRate = 0.1f;

    void Start () {
        ControlTime = Time.time + ControlTimeRate;
        nrocks = 100;
        rocks.quantidade = 1000;
        rocks.destroyeds = 0;
        rock = new GameObject[quantidade];
        



    }

    void Update () {

        if (Time.time > ControlTime && stones < quantidade)
        {
            ControlTime = Time.time + ControlTimeRate;
            rock[stones] = Instantiate(stone, Vector3.zero, Quaternion.identity) as GameObject;
            stones++;
            if (stones > nrocks)
            {
                ControlTimeRate *= 2;
                nrocks *= 1.5;
            }

        }

    }

    
}