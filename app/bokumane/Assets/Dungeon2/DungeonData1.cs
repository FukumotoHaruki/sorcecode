using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DungeonData1 : MonoBehaviour {
    public int TekiAttack1;
    public int TekiHp1;
    public int TekiAttack2;
    public int TekiHp2;
    public int TekiAttack3;
    public int TekiHp3;

    private TekiStatus teki;
    // Use this for initialization
    void Start () {
        TekiAttack1 = 60;
        TekiHp1 = 200;

        TekiAttack2 = 60;
        TekiHp2 = 200;

        TekiAttack3 = 70;
        TekiHp3 = 400;

        teki = GetComponent<TekiStatus>();
        teki.TekiStatusin();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
