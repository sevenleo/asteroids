using UnityEngine;
using System.Collections;

public  class Bonus : MonoBehaviour {

    public static GameObject[] sortbonuses { get; set; }
    public GameObject life;
    public GameObject fire;
    public GameObject timefreeze;
    public GameObject speedforce;
    public GameObject star;
    int sortcont;

    public GameObject bonus;
    // GameObject[] bonuses;
    //int cont;

    public static GameObject[] bonuses;
    public static int cont;

    // Use this for initialization
    void Start () {
        cont = 0;
        sortbonuses = new GameObject[5];
        sortbonuses[0] = life;
        sortbonuses[1] = fire;
        sortbonuses[2] = speedforce;
        sortbonuses[3] = timefreeze;
        sortbonuses[4] = star;


        if (PlayerPrefs.HasKey("level"))
        {

            if (PlayerPrefs.GetString("level") == "easy")
            {
                bonuses = new GameObject[100];
            }
            else if (PlayerPrefs.GetString("level") == "medium")
            {

                bonuses = new GameObject[400];
            }
            else if (PlayerPrefs.GetString("level") == "hard")
            {
                bonuses = new GameObject[1000];
            }
        }
        else
            Application.Quit();

    }

    // Update is called once per frame
    void Update () {
	
	}

    public static void newBonus( Vector3 Position, Quaternion Rotation)
    {
        GameObject bonus = Bonus.sortbonuses[Random.Range(0,4)] ;
        Debug.Log("BONUS " + cont);
        bonuses[cont] = Instantiate(bonus, Position, Rotation) as GameObject;
        cont++;

    }


}
