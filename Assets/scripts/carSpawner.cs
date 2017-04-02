using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carSpawner : MonoBehaviour {

    public GameObject[] cars;
    int carNo;
    public float maxPos = 1.3f;
    public float delay = 1f;
    float timer;

	// Use this for initialization
	void Start () {
        timer = delay;
	}
	
	// Update is called once per frame
	void Update () {
        timer -= Time.deltaTime;
        if (timer <= 0) { 
            Vector3 carPos = new Vector3(Random.Range(-maxPos, maxPos), transform.position.y, transform.position.z);
            carNo = Random.Range(0, 3);
            Instantiate(cars[carNo], carPos, transform.rotation);
            timer = delay;
        }
    }
}
