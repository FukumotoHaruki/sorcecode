using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMManager: MonoBehaviour {

	// Use this for initialization
	void Start () {
        GameObject.Find("BGM").GetComponent<AudioSource>().enabled = true;
        GameObject.Find("LastBossBGM").GetComponent<AudioSource>().enabled = false;
        GameObject.Find("VictoryBGM").GetComponent<AudioSource>().enabled = false;
        GameObject.Find("GameOverBGM").GetComponent<AudioSource>().enabled = false;
        GameObject.Find("DungeonSelectBGM").GetComponent<AudioSource>().enabled = false;
        GameObject.Find("LoserMonsterBGM").GetComponent<AudioSource>().enabled = false;
        GameObject.Find("BossBGM").GetComponent<AudioSource>().enabled = false;

        GameObject.Find("LevelUpBGM").GetComponent<AudioSource>().enabled = false;
        GameObject.Find("CureBGM").GetComponent<AudioSource>().enabled = false;
        GameObject.Find("SordAttackBGM").GetComponent<AudioSource>().enabled = false;
        GameObject.Find("AttackBGM").GetComponent<AudioSource>().enabled = false;
        GameObject.Find("BreakBGM").GetComponent<AudioSource>().enabled = false;
        GameObject.Find("ClickBGM").GetComponent<AudioSource>().enabled = false;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
