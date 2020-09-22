using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotGOBGM : MonoBehaviour {

    public void Change(){
        GameObject.Find("GameOverBGM").GetComponent<AudioSource>().enabled = false;
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
