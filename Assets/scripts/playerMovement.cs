using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour {

    public float playerSpeed = 10.0f;
    public float maxPos = 1.3f;
    Vector3 position;

    // Use this for initialization
	void Start ()
    {
        position = transform.position;
	}
	
	// Update is called once per frame
	void Update ()
    {
        position.x += Input.GetAxis("Horizontal") * playerSpeed * Time.deltaTime;
        position.x = Mathf.Clamp(position.x, -maxPos, maxPos);
        transform.position = position;
	}

    void OnCollisionEnter2D (Collision2D col)
    {
        if (col.gameObject.tag == "enemy")
        {
            Destroy(gameObject);
        }
     }

 }