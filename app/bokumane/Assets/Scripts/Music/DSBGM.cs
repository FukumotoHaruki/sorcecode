using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DSBGM : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        GameObject.Find("BGM").GetComponent<AudioSource>().enabled = false;
        GameObject.Find("DungeonSelectBGM").GetComponent<AudioSource>().enabled = true;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
