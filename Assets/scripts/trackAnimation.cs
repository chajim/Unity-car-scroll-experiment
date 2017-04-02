using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trackAnimation : MonoBehaviour {
    public float speedTrack = 1.0f;
    Vector2 offset;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        offset = new Vector2(0, Time.time * speedTrack);
        GetComponent<Renderer>().material.mainTextureOffset = offset;
	}
}
