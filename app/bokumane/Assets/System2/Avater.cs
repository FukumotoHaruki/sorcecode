using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text;
using System.IO;

public class Avater : MonoBehaviour {
    public static int LEVEL; 
    public static int EXP;

    public static int HP;
    public static int MP;
    public static int ATTACK;
    public static int DEFENSE;

    public static int WEAR;///外部保存、装備押したら数値変更

    // Use this for initialization

    public void WEARING()
    {
    }
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
        int[] Sstr = new int[6];
        Sstr[0] = int.Parse(S[0]);
        Sstr[1] = int.Parse(S[1]);
        Sstr[2] = int.Parse(S[2]);
        Sstr[3] = int.Parse(S[3]);
        Sstr[4] = int.Parse(S[4]);
        Sstr[5] = int.Parse(S[5]);

        

        LEVEL = Sstr[0];
        EXP = Sstr[1];
        HP = Sstr[2];
        MP = Sstr[3];
        ATTACK = Sstr[4];
        DEFENSE = Sstr[5];
        // StreamReaderを閉じる
        sr.Close();

        string[] W = new string[41];

        StreamReader srW = new StreamReader("DropData.txt", Encoding.GetEncoding("UTF-8"));
        for (int i = 0; i < 41; i++)
        {

            string line = srW.ReadLine();
            W[i] = line;
        }
        int[] Wstr = new int[41];
        Wstr[40] = int.Parse(W[40]);

        WEAR = Wstr[40];
        // StreamReaderを閉じる
        srW.Close();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
