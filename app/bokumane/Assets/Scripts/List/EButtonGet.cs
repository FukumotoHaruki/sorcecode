using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text;
using System.IO;

public class EButtonGet : MonoBehaviour {

   
    public GameObject ExpImage;
    public GameObject Canvas;

    public void ExpButton()
    {
        Canvas = GameObject.Find("Canvas");

        var toggle = this.GetComponentInChildren<Toggle>();
        if (toggle.isOn)
        {
            ExpImage = (GameObject)Resources.Load("Prefabs/ExpImage");

            //ExpImage = GameObject.Find("Canvas/ExpImage");
            //ExpImage.SetActive(true);
            //.transform.SetParent();

            var make = Instantiate(ExpImage);
            make.transform.SetParent(Canvas.transform, false);

            //Instantiate(ExpImage, transform.position, Quaternion.identity);
        }
    }
    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
