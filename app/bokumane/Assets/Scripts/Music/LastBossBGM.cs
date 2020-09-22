using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LastBossBGM : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        GameObject.Find("LoserMonsterBGM").GetComponent<AudioSource>().enabled = false;
        GameObject.Find("LastBossBGM").GetComponent<AudioSource>().enabled = true;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
