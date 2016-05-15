using UnityEngine;
using System.Collections;

public class rocks : MonoBehaviour {

    int quantidade = 500;
    public GameObject stone;
    //GameObject[] rock;
    GameObject rock;
    int stones = 0;

    void Start () {
        rock = Instantiate(stone, Vector3.zero, Quaternion.identity) as GameObject;
        //rock = new GameObject[quantidade];

        while (stones < quantidade)        {
            //rock[stones] =Instantiate(stone, Vector3.zero, Quaternion.identity) as GameObject;
            rock = Instantiate(stone, Vector3.zero, Quaternion.identity) as GameObject;
            stones++;
        }
        
    }

    void Update () {
    }
}
