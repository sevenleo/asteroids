using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class levels : MonoBehaviour {

    public static string level { get; set; }
    public static int lifes { get; set; }
    public static float safedistance { get; set; }
    public static float distance { get; set; }
    public static float force { get; set; }
    public static int rotate { get; set; }
    public static int RocksQuantity { get; set; }
    public static float RocksControlTimeRate { get; set; }
    public static float fireRate { get; set; }

// Use this for initialization
    void Start () {
        level = SceneManager.GetActiveScene().name;

        if (level == "easy")
        {
            lifes = 3;
            safedistance = 0.50f;
            distance = 200.0f;
            force = 0;
            rotate = 360;
            RocksQuantity = 100;
            RocksControlTimeRate = 0.1f;
            fireRate = 0.1f;
        }
        else if (level == "medium")
        {
            lifes = 2;
            safedistance = 0.30f;
            distance = 200.0f;
            force = 1000f;
            rotate = 360;
            RocksQuantity = 400;
            RocksControlTimeRate = 0.1f;
            fireRate = 0.2f;
        }
        else if (level == "hard")
        {
            lifes = 1;
            safedistance = 0.10f;
            distance = 200.0f;
            force = 5000f;
            rotate = 360;
            RocksQuantity = 1000;
            RocksControlTimeRate = 0.1f;
            fireRate = 0.3f;
        }

    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
