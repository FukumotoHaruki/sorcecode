using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DungeonData2 : MonoBehaviour {
    public int TekiAttack1;
    public int TekiHp1;
    public int TekiAttack2;
    public int TekiHp2;
    public int TekiAttack3;
    public int TekiHp3;

    private TekiStatus teki;
    // Use this for initialization
    void Start () {
        TekiAttack1 = 100;
        TekiHp1 = 1000;

        TekiAttack2 = 100;
        TekiHp2 = 1000;

        TekiAttack3 = 170;
        TekiHp3 = 5000;

        teki = GetComponent<TekiStatus>();
        teki.TekiStatusin();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
