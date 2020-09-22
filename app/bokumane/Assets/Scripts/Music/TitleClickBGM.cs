using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleClickBGM : MonoBehaviour {
    public AudioSource AS;
    public AudioClip A;
    public void OnClick()
    {
        AS.PlayOneShot(A);
    }
    void Start()
    {
        AS = GetComponent<AudioSource>();
    }
    

	// Update is called once per frame
	void Update () {
		
	}
}
