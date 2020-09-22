using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text;
using System.IO;

public class ExpButtonDelete : MonoBehaviour {

    GameObject ExpImage;

    public void ButtonDelete()
    {
        ExpImage = GameObject.Find("Canvas/ExpImage");

        ExpImage.SetActive(false);
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
