using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.SceneManagement;


public class uiManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Play()
    {
        //SceneManager.LoadScene("lvl1");
        Application.LoadLevel("lvl1");

    }

    public void Pause()
    {
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
        } else if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
        }
    }
}
