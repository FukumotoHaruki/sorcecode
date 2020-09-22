using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sentaku : MonoBehaviour {


    public void BottonPush()
    {
        if (Dungeon.DUNGEON == 1)
        {
            SceneManager.LoadScene("Battle1-1");
        }
        else if (Dungeon.DUNGEON == 2)
        {
            SceneManager.LoadScene("Battle2-1");
        }
        else if (Dungeon.DUNGEON == 3)
        {
            SceneManager.LoadScene("Battle3-1");
        }
        else if (Dungeon.DUNGEON == 4)
        {
            SceneManager.LoadScene("Battle4-1");
        }
        else if (Dungeon.DUNGEON == 5)
        {
            SceneManager.LoadScene("Battle5-1");
        }
    }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
