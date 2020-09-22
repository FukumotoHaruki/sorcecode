using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text;
using System.IO;

public class Drop : MonoBehaviour {
    public int random;
    public int rare;

    const string boxName = "box";
    private GameObject boxObj;
    const string getName = "get";
    private GameObject getObj;

    const string a1Name = "a1";
    private GameObject a1;
    const string b1Name = "b1";
    private GameObject b1;
    const string c1Name = "c1";
    private GameObject c1;
    const string d1Name = "d1";
    private GameObject d1;
    const string e1Name = "e1";
    private GameObject e1;

    const string A1Name = "A1";
    private GameObject A1;
    const string B1Name = "B1";
    private GameObject B1;
    const string C1Name = "C1";
    private GameObject C1;
    const string D1Name = "D1";
    private GameObject D1;
    const string E1Name = "E1";
    private GameObject E1;

    const string a2Name = "a2";
    private GameObject a2;
    const string b2Name = "b2";
    private GameObject b2;
    const string c2Name = "c2";
    private GameObject c2;
    const string d2Name = "d2";
    private GameObject d2;
    const string e2Name = "e2";
    private GameObject e2;

    const string A2Name = "A2";
    private GameObject A2;
    const string B2Name = "B2";
    private GameObject B2;
    const string C2Name = "C2";
    private GameObject C2;
    const string D2Name = "D2";
    private GameObject D2;
    const string E2Name = "E2";
    private GameObject E2;

    const string a3Name = "a3";
    private GameObject a3;
    const string b3Name = "b3";
    private GameObject b3;
    const string c3Name = "c3";
    private GameObject c3;
    const string d3Name = "d3";
    private GameObject d3;
    const string e3Name = "e3";
    private GameObject e3;

    const string A3Name = "A3";
    private GameObject A3;
    const string B3Name = "B3";
    private GameObject B3;
    const string C3Name = "C3";
    private GameObject C3;
    const string D3Name = "D3";
    private GameObject D3;
    const string E3Name = "E3";
    private GameObject E3;

    const string a4Name = "a4";
    private GameObject a4;
    const string b4Name = "b4";
    private GameObject b4;
    const string c4Name = "c4";
    private GameObject c4;
    const string d4Name = "d4";
    private GameObject d4;
    const string e4Name = "e4";
    private GameObject e4;

    const string A4Name = "A4";
    private GameObject A4;
    const string B4Name = "B4";
    private GameObject B4;
    const string C4Name = "C4";
    private GameObject C4;
    const string D4Name = "D4";
    private GameObject D4;
    const string E4Name = "E4";
    private GameObject E4;
    // Use this for initialization
    public void drop(int x)
    {
        random = Random.Range(1, 100);
        rare = Random.Range(1, 20);

        //Debug.Log(random);
        //Debug.Log(rare);

        string[] W = new string[41];

        StreamReader srW = new StreamReader("DropData.txt", Encoding.GetEncoding("UTF-8"));
        for (int i = 0; i < 41; i++)
        {

            string line = srW.ReadLine();
            W[i] = line;
        }
        // StreamReaderを閉じる
        srW.Close();

        StreamWriter swW = new StreamWriter(@"DropData.txt", false, Encoding.GetEncoding("UTF-8"));
        if (random < 61)
        {
            boxObj.SetActive(true);
            getObj.SetActive(true);
        }
        if (random < 16)
        {
            if(x == 1)
            {
                if(rare == 1)
                {
                    A1.SetActive(true);
                    W[0] = "1";
                }
                else
                {
                    a1.SetActive(true);
                    W[1] = "1";
                }
            }
            else if(x == 2)
            {
                if (rare == 1)
                {
                    B1.SetActive(true);
                    W[2] = "1";
                }
                else
                {
                    b1.SetActive(true);
                    W[3] = "1";
                }
            }
            else if (x == 3)
            {
                if (rare == 1)
                {
                    C1.SetActive(true);
                    W[4] = "1";
                }
                else
                {
                    c1.SetActive(true);
                    W[5] = "1";
                }
            }
            else if (x == 4)
            {
                if (rare == 1)
                {
                    D1.SetActive(true);
                    W[6] = "1";
                }
                else
                {
                    d1.SetActive(true);
                    W[7] = "1";
                }
            }
            else if (x == 5)
            {
                if (rare == 1)
                {
                    E1.SetActive(true);
                    W[8] = "1";
                }
                else
                {
                    e1.SetActive(true);
                    W[9] = "1";
                }
            }
        }
        else if(random >= 16 && random < 31)
        {
            if (x == 1)
            {
                if (rare == 1)
                {
                    A2.SetActive(true);
                    W[10] = "1";
                }
                else
                {
                    a2.SetActive(true);
                    W[11] = "1";
                }
            }
            else if (x == 2)
            {
                if (rare == 1)
                {
                    B2.SetActive(true);
                    W[12] = "1";
                }
                else
                {
                    b2.SetActive(true);
                    W[13] = "1";
                }
            }
            else if (x == 3)
            {
                if (rare == 1)
                {
                    C2.SetActive(true);
                    W[14] = "1";
                }
                else
                {
                    c2.SetActive(true);
                    W[15] = "1";
                }
            }
            else if (x == 4)
            {
                if (rare == 1)
                {
                    D2.SetActive(true);
                    W[16] = "1";
                }
                else
                {
                    d2.SetActive(true);
                    W[17] = "1";
                }
            }
            else if (x == 5)
            {
                if (rare == 1)
                {
                    E2.SetActive(true);
                    W[18] = "1";
                }
                else
                {
                    e2.SetActive(true);
                    W[19] = "1";
                }
            }
        }
        else if(random >= 31 && random < 46)
        {
            if (x == 1)
            {
                if (rare == 1)
                {
                    A3.SetActive(true);
                    W[20] = "1";
                }
                else
                {
                    a3.SetActive(true);
                    W[21] = "1";
                }
            }
            else if (x == 2)
            {
                if (rare == 1)
                {
                    B3.SetActive(true);
                    W[22] = "1";
                }
                else
                {
                    b3.SetActive(true);
                    W[23] = "1";
                }
            }
            else if (x == 3)
            {
                if (rare == 1)
                {
                    C3.SetActive(true);
                    W[24] = "1";
                }
                else
                {
                    c3.SetActive(true);
                    W[25] = "1";
                }
            }
            else if (x == 4)
            {
                if (rare == 1)
                {
                    D3.SetActive(true);
                    W[26] = "1";
                }
                else
                {
                    d3.SetActive(true);
                    W[27] = "1";
                }
            }
            else if (x == 5)
            {
                if (rare == 1)
                {
                    E3.SetActive(true);
                    W[28] = "1";
                }
                else
                {
                    e3.SetActive(true);
                    W[29] = "1";
                }
            }
        }
        else if(random >= 46 && random < 61)
        {
            if (x == 1)
            {
                if (rare == 1)
                {
                    A4.SetActive(true);
                    W[30] = "1";
                }
                else
                {
                    a4.SetActive(true);
                    W[31] = "1";
                }
            }
            else if (x == 2)
            {
                if (rare == 1)
                {
                    B4.SetActive(true);
                    W[32] = "1";
                }
                else
                {
                    b4.SetActive(true);
                    W[33] = "1";
                }
            }
            else if (x == 3)
            {
                if (rare == 1)
                {
                    C4.SetActive(true);
                    W[34] = "1";
                }
                else
                {
                    c4.SetActive(true);
                    W[35] = "1";
                }
            }
            else if (x == 4)
            {
                if (rare == 1)
                {
                    D4.SetActive(true);
                    W[36] = "1";
                }
                else
                {
                    d4.SetActive(true);
                    W[37] = "1";
                }
            }
            else if (x == 5)
            {
                if (rare == 1)
                {
                    E4.SetActive(true);
                    W[38] = "1";
                }
                else
                {
                    e4.SetActive(true);
                    W[39] = "1";
                }
            }
        }
        for (int i = 0; i < 41; i++)
        {
            string Ew = W[i];
            swW.WriteLine(Ew);
        }

        swW.Close();
    }

    public void ObjGet()
    {
        a1 = GameObject.Find(a1Name);
        a1.SetActive(false);
        b1 = GameObject.Find(b1Name);
        b1.SetActive(false);
        c1 = GameObject.Find(c1Name);
        c1.SetActive(false);
        d1 = GameObject.Find(d1Name);
        d1.SetActive(false);
        e1 = GameObject.Find(e1Name);
        e1.SetActive(false);

        A1 = GameObject.Find(A1Name);
        A1.SetActive(false);
        B1 = GameObject.Find(B1Name);
        B1.SetActive(false);
        C1 = GameObject.Find(C1Name);
        C1.SetActive(false);
        D1 = GameObject.Find(D1Name);
        D1.SetActive(false);
        E1 = GameObject.Find(E1Name);
        E1.SetActive(false);

        a2 = GameObject.Find(a2Name);
        a2.SetActive(false);
        b2 = GameObject.Find(b2Name);
        b2.SetActive(false);
        c2 = GameObject.Find(c2Name);
        c2.SetActive(false);
        d2 = GameObject.Find(d2Name);
        d2.SetActive(false);
        e2 = GameObject.Find(e2Name);
        e2.SetActive(false);

        A2 = GameObject.Find(A2Name);
        A2.SetActive(false);
        B2 = GameObject.Find(B2Name);
        B2.SetActive(false);
        C2 = GameObject.Find(C2Name);
        C2.SetActive(false);
        D2 = GameObject.Find(D2Name);
        D2.SetActive(false);
        E2 = GameObject.Find(E2Name);
        E2.SetActive(false);

        a3 = GameObject.Find(a3Name);
        a3.SetActive(false);
        b3 = GameObject.Find(b3Name);
        b3.SetActive(false);
        c3 = GameObject.Find(c3Name);
        c3.SetActive(false);
        d3 = GameObject.Find(d3Name);
        d3.SetActive(false);
        e3 = GameObject.Find(e3Name);
        e3.SetActive(false);

        A3 = GameObject.Find(A3Name);
        A3.SetActive(false);
        B3 = GameObject.Find(B3Name);
        B3.SetActive(false);
        C3 = GameObject.Find(C3Name);
        C3.SetActive(false);
        D3 = GameObject.Find(D3Name);
        D3.SetActive(false);
        E3 = GameObject.Find(E3Name);
        E3.SetActive(false);

        a4 = GameObject.Find(a4Name);
        a4.SetActive(false);
        b4 = GameObject.Find(b4Name);
        b4.SetActive(false);
        c4 = GameObject.Find(c4Name);
        c4.SetActive(false);
        d4 = GameObject.Find(d4Name);
        d4.SetActive(false);
        e4 = GameObject.Find(e4Name);
        e4.SetActive(false);

        A4 = GameObject.Find(A4Name);
        A4.SetActive(false);
        B4 = GameObject.Find(B4Name);
        B4.SetActive(false);
        C4 = GameObject.Find(C4Name);
        C4.SetActive(false);
        D4 = GameObject.Find(D4Name);
        D4.SetActive(false);
        E4 = GameObject.Find(E4Name);
        E4.SetActive(false);
    }
    void Start () {
        boxObj = GameObject.Find(boxName);
        getObj = GameObject.Find(getName);
        boxObj.SetActive(false);
        getObj.SetActive(false);

        ObjGet();

        drop(Dungeon.DUNGEON);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
