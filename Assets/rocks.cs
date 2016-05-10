using UnityEngine;
using System.Collections;

public class rocks : MonoBehaviour {

    public GameObject rock;
    Rigidbody rockA;
    float distance = 1000.0f;
    Vector3 randposition;

     void Start () {
        Random.seed = (int)System.DateTime.Now.Ticks;
        rockA = Instantiate(rock, new Vector3(Random.value * distance, Random.value * distance, Random.value * distance), transform.rotation) as Rigidbody;
        rockA = Instantiate(rock, new Vector3(Random.value * distance, Random.value * distance, Random.value * distance), transform.rotation) as Rigidbody;
        rockA = Instantiate(rock, new Vector3(Random.value * distance, Random.value * distance, Random.value * distance), transform.rotation) as Rigidbody;
        rockA = Instantiate(rock, new Vector3(Random.value * distance, Random.value * distance, Random.value * distance), transform.rotation) as Rigidbody;
        rockA = Instantiate(rock, new Vector3(Random.value * distance, Random.value * distance, Random.value * distance), transform.rotation) as Rigidbody;
        rockA = Instantiate(rock, new Vector3(Random.value * distance, Random.value * distance, Random.value * distance), transform.rotation) as Rigidbody;
        rockA = Instantiate(rock, new Vector3(Random.value * distance, Random.value * distance, Random.value * distance), transform.rotation) as Rigidbody;


    }

    void Update () {
        //rockA.transform.position = new Vector3(Random.value * distance, Random.value * distance, Random.value * distance);
    }
}
