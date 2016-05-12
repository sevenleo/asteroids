using UnityEngine;
using System.Collections;

public class rocks : MonoBehaviour {

    public GameObject stone;
    Rigidbody rock;
    float distance = 1000.0f;
    float delay = 1.0f;
    bool rocking;
    int stones = 0;
    Vector3 randomposition;

    Vector3 randposition;
    

    void Start () {
        Random.seed = (int)System.DateTime.Now.Ticks;
        //rocking = true;
       
        while(stones < 500)
        {
            Vector3 randomposition = this.transform.position - new Vector3(distance / 2, distance / 2, distance / 2) + new Vector3(Random.value * distance, Random.value * distance, Random.value * distance);
            rock = Instantiate(stone, randomposition, transform.rotation) as Rigidbody;
            
            stones++;

        }

    }

    void Update () {
        /*
            if (stones < 10) {
                //yield return new WaitForSeconds(1);
                Vector3 randomposition = this.transform.position - new Vector3(distance / 2, distance / 2, distance / 2) + new Vector3(Random.value * distance, Random.value * distance, Random.value * distance);
                rock = Instantiate(stone, randomposition, transform.rotation) as Rigidbody;
                rock.tag = "rock";
                stones++; 
            } */

        



    }
}
