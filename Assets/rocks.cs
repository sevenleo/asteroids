using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class rocks : MonoBehaviour {
    
  
    public static int destroyeds { get; set; }
    public static int stones { get; set; }
  
    public GameObject stone;
    GameObject[] rock;
    double nrocks;
    float ControlTime;
    float RocksControlTimeRate;
    int RocksQuantity;

    void Start () {

        //Quantity = levels.RocksQuantity;
        //Quantity = 1000;
        //ControlTimeRate = levels.RocksControlTimeRate;
        //ControlTimeRate = 0.1f;

        if (PlayerPrefs.HasKey("level"))   {

            if (PlayerPrefs.GetString("level") == "easy")
            {
                RocksQuantity = 100;
                RocksControlTimeRate = 0.1f;
            }
            else if (PlayerPrefs.GetString("level") == "medium")
            {

                RocksQuantity = 400;
                RocksControlTimeRate = 0.1f;
            }
            else if (PlayerPrefs.GetString("level") == "hard")
            {

                RocksQuantity = 1000;
                RocksControlTimeRate = 0.1f;
            }
        }
        else
            Application.Quit();



        ControlTime = Time.time + RocksControlTimeRate;
                
        rock = new GameObject[RocksQuantity];
        nrocks = RocksQuantity / 10;
        rocks.destroyeds = 0;
        stones = 0;
    }

    void Update () {

        if (Time.time > ControlTime && stones < RocksQuantity) {
            ControlTime = Time.time + RocksControlTimeRate;
            rock[stones] = Instantiate(stone, Vector3.zero, Quaternion.identity) as GameObject;
            stones++;
            if (stones > nrocks)
            {
                RocksControlTimeRate *= 2;
                nrocks *= 1.5;
            }
        }
    }
}