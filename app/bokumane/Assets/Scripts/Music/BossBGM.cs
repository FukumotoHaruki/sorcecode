using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBGM : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        GameObject.Find("LoserMonsterBGM").GetComponent<AudioSource>().enabled = false;
        GameObject.Find("BossBGM").GetComponent<AudioSource>().enabled = true;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
