using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DungeonData5 : MonoBehaviour {
    public int TekiAttack1;
    public int TekiHp1;
    public int TekiAttack2;
    public int TekiHp2;
    public int TekiAttack3;
    public int TekiHp3;

    private TekiStatus teki;
    // Use this for initialization
    void Start () {
        TekiAttack1 = 250;
        TekiHp1 = 5000;

        TekiAttack2 = 300;
        TekiHp2 = 7100;

        TekiAttack3 = 550;
        TekiHp3 = 12000;

        teki = GetComponent<TekiStatus>();
        teki.TekiStatusin();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
