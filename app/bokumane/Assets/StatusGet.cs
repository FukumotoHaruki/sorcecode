using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text;
using System.IO;

public class StatusGet : MonoBehaviour {
    public static int LEVEL;
    public static int EXP;

    public static int HP;
    public static int MP;
    public static int ATTACK;
    public static int DEFENSE;

    public static int WEAR = 0;

    // Use this for initialization
    void Start () {
        string[] S = new string[6];
        S[0] = "";
        S[1] = "";
        S[2] = "";
        S[3] = "";
        S[4] = "";
        S[5] = "";

        StreamReader sr = new StreamReader("StatusData.txt", Encoding.GetEncoding("UTF-8"));
        for (int i = 0; i < 6; i++)
        {

            string line = sr.ReadLine();
            S[i] = line;
        }
        // StreamReaderを閉じる
        sr.Close();

        int[] Sstr = new int[6];
        Sstr[0] = int.Parse(S[0]);
        Sstr[1] = int.Parse(S[0]);
        Sstr[2] = int.Parse(S[0]);
        Sstr[3] = int.Parse(S[0]);
        Sstr[4] = int.Parse(S[0]);
        Sstr[5] = int.Parse(S[0]);

        LEVEL = Sstr[0];
        EXP = Sstr[1];
        HP = Sstr[2];
        MP = Sstr[3];
        ATTACK = Sstr[4];
        DEFENSE = Sstr[5];

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
