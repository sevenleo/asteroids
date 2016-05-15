using UnityEngine;
using System.Collections;

public class rocks : MonoBehaviour {

    int quantidade = 1000;
    public GameObject stone;
    GameObject[] rock;
    int stones = 0;
    private float ControlTime;
    private float ControlTimeRate = 0.1f;

    void Start () {
        ControlTime = Time.time + ControlTimeRate;
        rock = new GameObject[quantidade];


        
    }

    void Update () {

        if (Time.time > ControlTime && stones < quantidade)
        {
            ControlTime = Time.time + ControlTimeRate;
            rock[stones] = Instantiate(stone, Vector3.zero, Quaternion.identity) as GameObject;
            stones++;

        }

        }
}