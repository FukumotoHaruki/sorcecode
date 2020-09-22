using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Command1 : MonoBehaviour {
    const string BattleName = "BattleObject";
    private GameObject BattleObj;
    private Battle battle;

    const string ButtonName1 = "Button1";
    private GameObject buttonObj1;
    const string ButtonName2 = "Button2";
    private GameObject buttonObj2;
    const string ButtonName3 = "Button3";
    private GameObject buttonObj3;
    const string ButtonName4 = "Button4";
    private GameObject buttonObj4;
    public void ButtonPush()
    {
        BattleObj = GameObject.Find(BattleName);
        battle = BattleObj.GetComponent<Battle>();
        battle.Battles(1);
        buttonObj1.SetActive(false);
        buttonObj2.SetActive(false);
        buttonObj3.SetActive(false);
        buttonObj4.SetActive(false);
    }
    // Use this for initialization
    void Start ()
    {
        buttonObj1 = GameObject.Find(ButtonName1);
        buttonObj2 = GameObject.Find(ButtonName2);
        buttonObj3 = GameObject.Find(ButtonName3);
        buttonObj4 = GameObject.Find(ButtonName4);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
