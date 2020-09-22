using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleWear : MonoBehaviour {
    const string wearName = "Avater0";
    private GameObject wear;

    const string aName = "Avatera";
    private GameObject a;
    const string AName = "AvaterA";
    private GameObject A;

    const string bName = "Avaterb";
    private GameObject b;
    const string BName = "AvaterB";
    private GameObject B;

    const string cName = "Avaterc";
    private GameObject c;
    const string CName = "AvaterC";
    private GameObject C;

    const string dName = "Avaterd";
    private GameObject d;
    const string DName = "AvaterD";
    private GameObject D;

    const string eName = "Avatere";
    private GameObject e;
    const string EName = "AvaterE";
    private GameObject E;
    // Use this for initialization
    public void SetWear()
    {
        if(Avater.WEAR == 0)
        {
            wear.SetActive(true);
        }
        else if (Avater.WEAR == 1)
        {
            a.SetActive(true);
        }
        else if (Avater.WEAR == 2)
        {
            b.SetActive(true);
        }
        else if (Avater.WEAR == 3)
        {
            c.SetActive(true);
        }
        else if (Avater.WEAR == 4)
        {
            d.SetActive(true);
        }
        else if (Avater.WEAR == 5)
        {
            e.SetActive(true);
        }
        else if (Avater.WEAR == 6)
        {
            A.SetActive(true);
        }
        else if (Avater.WEAR == 7)
        {
            B.SetActive(true);
        }
        else if (Avater.WEAR == 8)
        {
            C.SetActive(true);
        }
        else if (Avater.WEAR == 9)
        {
            D.SetActive(true);
        }
        else if (Avater.WEAR == 10)
        {
            E.SetActive(true);
        }
        else
        {
            wear.SetActive(true);
        }
    }
    void Start () {
        wear = GameObject.Find(wearName);
        wear.SetActive(false);

        a = GameObject.Find(aName);
        a.SetActive(false);
        A = GameObject.Find(AName);
        A.SetActive(false);

        b = GameObject.Find(bName);
        b.SetActive(false);
        B = GameObject.Find(BName);
        B.SetActive(false);

        c = GameObject.Find(cName);
        c.SetActive(false);
        C = GameObject.Find(CName);
        C.SetActive(false);

        d = GameObject.Find(dName);
        d.SetActive(false);
        D = GameObject.Find(DName);
        D.SetActive(false);

        e = GameObject.Find(eName);
        e.SetActive(false);
        E = GameObject.Find(EName);
        E.SetActive(false);

        wear.SetActive(false);
        a.SetActive(false);
        A.SetActive(false);
        b.SetActive(false);
        B.SetActive(false);
        c.SetActive(false);
        C.SetActive(false);
        d.SetActive(false);
        D.SetActive(false);
        e.SetActive(false);
        E.SetActive(false);

        SetWear();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
