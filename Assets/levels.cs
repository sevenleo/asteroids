using UnityEngine;
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

        if (PlayerPrefs.HasKey("level"))
        {

            if (PlayerPrefs.GetString("level") == "easy")
            {
                lifes = 3;
                safedistance = 0.50f;
                distance = 200.0f;
                force = 0;
                rotate = 360;
                fireRate = 0.1f;
                RocksQuantity = 100;
                RocksControlTimeRate = 0.1f;
            }
            else if (PlayerPrefs.GetString("level") == "medium")
            {
                lifes = 2;
                safedistance = 0.30f;
                distance = 200.0f;
                force = 1000f;
                rotate = 360;
                fireRate = 0.2f;
                RocksQuantity = 400;
                RocksControlTimeRate = 0.1f;
            }
            else if (PlayerPrefs.GetString("level") == "hard")
            {
                lifes = 1;
                safedistance = 0.10f;
                distance = 200.0f;
                force = 5000f;
                rotate = 360;
                fireRate = 0.3f;
                RocksQuantity = 1000;
                RocksControlTimeRate = 0.1f;
                GameObject.FindGameObjectWithTag("pointer").GetComponent<Renderer>().enabled = false;
            }
        }
    }
	

}
