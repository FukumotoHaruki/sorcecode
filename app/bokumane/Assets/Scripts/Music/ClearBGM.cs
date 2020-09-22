using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearBGM : MonoBehaviour {

	// Use this for initialization
	void Start () {
        if (GameObject.Find("BossBGM").GetComponent<AudioSource>().enabled) {
            GameObject.Find("BossBGM").GetComponent<AudioSource>().enabled = false;
        }
        if (GameObject.Find("LastBossBGM").GetComponent<AudioSource>().enabled){
            GameObject.Find("LastBossBGM").GetComponent<AudioSource>().enabled = false;
        }

        GameObject.Find("VictoryBGM").GetComponent<AudioSource>().enabled = true;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
