using UnityEngine;
using System.Collections;

public class rocks : MonoBehaviour {

    public GameObject stone;
    GameObject rock;
    float distance = 1000.0f;
    float force = 1000f;
    bool rocking=true;
    int stones = 0;
    int rotate = 180;
    Vector3 randomposition;
    Vector3 randomforce;
    Vector3 safedistance;
    Quaternion randomrotate;
    


    void Start () {
        Random.seed = (int)System.DateTime.Now.Ticks;
        safedistance = new Vector3(10, 10, 10);

        while (stones < 500)        {
                   
            randomposition = this.transform.position + safedistance + new Vector3(Random.Range(-distance,distance), Random.Range(-distance, distance), Random.Range(-distance, distance));
            randomrotate = new Quaternion(Random.Range(-rotate, rotate), Random.Range(-rotate, rotate), Random.Range(-rotate, rotate),rotate);
            rock = Instantiate(stone, randomposition, transform.rotation) as GameObject;
            randomforce = new Vector3(Random.Range(-force, force), Random.Range(-force, force), Random.Range(-force, force));
            rock.GetComponent<Rigidbody>().AddForce(randomforce, ForceMode.Force);
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
