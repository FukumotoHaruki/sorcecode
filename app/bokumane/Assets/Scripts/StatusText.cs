using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text;
using System.IO;

public class StatusText : MonoBehaviour {

    public Text L;
    public Text E;
    public Text H;
    public Text M;
    public Text A;
    public Text D;

    // Use this for initialization
    void Start () {
        StreamReader sr = new StreamReader("StatusData.txt", Encoding.GetEncoding("UTF-8"));

        string[] S = new string[6];
        for (int j = 0; j < 6; j++)
        {
            string line = sr.ReadLine();
            S[j] = line;
        }

        int e = int.Parse(S[1]);
        int ex = 10 - (e % 10);
        string exp = ex.ToString();

        int h = int.Parse(S[2]);
        int a = int.Parse(S[4]);

        if(Avater.WEAR == 1)
        {
            h = h + 25;
            a = a + 5;
        }else if (Avater.WEAR == 2)
        {
            h = h + 75;
            a = a + 15;
        }
        else if (Avater.WEAR == 3)
        {
            h = h + 125;
            a = a + 25;
        }
        else if (Avater.WEAR == 4)
        {
            h = h + 175;
            a = a + 35;
        }
        else if (Avater.WEAR == 5)
        {
            h = h + 225;
            a = a + 45;
        }
        else if (Avater.WEAR == 6)
        {
            h = h + 50;
            a = a + 10;
        }
        else if (Avater.WEAR == 7)
        {
            h = h + 100;
            a = a + 20;
        }
        else if (Avater.WEAR == 8)
        {
            h = h + 150;
            a = a + 30;
        }
        else if (Avater.WEAR == 9)
        {
            h = h + 200;
            a = a + 40;
        }
        else if (Avater.WEAR == 10)
        {
            h = h + 250;
            a = a + 50;
        }

        string hp = h.ToString();
        string attack = a.ToString();

        L.text = S[0];
        E.text = exp;
        H.text = hp;
        M.text = S[3];
        A.text = attack;
        D.text = S[5];


        // StreamReaderを閉じる
        sr.Close();

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
