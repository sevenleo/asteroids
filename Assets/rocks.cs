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
    //float ControlTimeRate;
    //int Quantity;

    void Start () {
        
        //Quantity = levels.RocksQuantity;
        //Quantity = 1000;
        //ControlTimeRate = levels.RocksControlTimeRate;
        //ControlTimeRate = 0.1f;



        ControlTime = Time.time + levels.RocksControlTimeRate;
                
        rock = new GameObject[levels.RocksQuantity];
        nrocks = levels.RocksQuantity / 10;
        rocks.destroyeds = 0;
        stones = 0;
    }

    void Update () {
        GameObject.FindGameObjectWithTag("ingamelifes").GetComponent<Text>().text = "Q:" + levels.RocksQuantity + "   T:" + levels.RocksControlTimeRate + "   dq:"+levels.RocksQuantity;

        if (Time.time > ControlTime && stones < levels.RocksQuantity) {
            ControlTime = Time.time + levels.RocksControlTimeRate;
            rock[stones] = Instantiate(stone, Vector3.zero, Quaternion.identity) as GameObject;
            stones++;
            if (stones > nrocks)
            {
                levels.RocksControlTimeRate *= 2;
                nrocks *= 1.5;
            }
        }
    }
}