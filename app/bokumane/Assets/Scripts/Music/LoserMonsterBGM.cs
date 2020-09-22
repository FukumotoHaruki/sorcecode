using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoserMonsterBGM : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GameObject.Find("DungeonSelectBGM").GetComponent<AudioSource>().enabled = false;
        GameObject.Find("LoserMonsterBGM").GetComponent<AudioSource>().enabled = true;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
