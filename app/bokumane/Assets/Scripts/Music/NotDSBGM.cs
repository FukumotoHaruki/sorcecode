using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotDSBGM : MonoBehaviour
{
    public void Change(){
        GameObject.Find("BGM").GetComponent<AudioSource>().enabled = true;
        GameObject.Find("DungeonSelectBGM").GetComponent<AudioSource>().enabled = false;
    }
    

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}