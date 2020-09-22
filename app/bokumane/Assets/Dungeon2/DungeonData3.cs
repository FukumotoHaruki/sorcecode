using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DungeonData3 : MonoBehaviour {
    public int TekiAttack1;
    public int TekiHp1;
    public int TekiAttack2;
    public int TekiHp2;
    public int TekiAttack3;
    public int TekiHp3;

    private TekiStatus teki;
    // Use this for initialization
    void Start () {
        TekiAttack1 = 80;
        TekiHp1 = 400;

        TekiAttack2 = 80;
        TekiHp2 = 400;

        TekiAttack3 = 100;
        TekiHp3 = 700;
        

        teki = GetComponent<TekiStatus>();
        teki.TekiStatusin();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
