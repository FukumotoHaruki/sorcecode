using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text;
using System.IO;

public class ExpGet : MonoBehaviour {
    private int LEVEL;
    public static int EXP;

    public static int HP;
    public static int MP;
    public static int ATTACK;
    public static int DEFENSE;

    GameObject ExpImage;

    public void ExpButton()
    {
        ExpImage.SetActive(true);
    }

    public void EXPGET()
    {
        StreamReader sr = new StreamReader("StatusData.txt", Encoding.GetEncoding("UTF-8"));
        string[] Sr = new string[6];
        for (int j = 0; j < 6; j++)
        {
            string line = sr.ReadLine();
            Sr[j] = line;
        }

        sr.Close();

        StreamWriter sw = new StreamWriter(@"StatusData.txt", false, Encoding.GetEncoding("UTF-8"));
        string[] Sw = new string[6];
        for (int j = 0; j < 6; j++)
        {
            Sw[j] = Sr[j];
        }

        EXP = int.Parse(Sw[1]);

        EXP += 1;

        Sw[1] = EXP.ToString();

        for (int i = 0; i < 6; i++)
        {
            string Ew = Sw[i];
            sw.WriteLine(Ew);
        }

        sw.Close();

        Avater.EXP += 1;

        if (EXP % 10 == 0)
        {
            LEVELUP();
        }



    }

    public  void LEVELUP()
    {
        StreamReader sr = new StreamReader("StatusData.txt", Encoding.GetEncoding("UTF-8"));
        string[] Sr = new string[6];
        for (int j = 0; j < 6; j++)
        {
            string line = sr.ReadLine();
            Sr[j] = line;
        }

        sr.Close();

        StreamWriter sw = new StreamWriter(@"StatusData.txt", false, Encoding.GetEncoding("UTF-8"));

        LEVEL = int.Parse(Sr[0]);
        HP = int.Parse(Sr[2]);
        MP = int.Parse(Sr[3]);
        ATTACK = int.Parse(Sr[4]);
        DEFENSE = int.Parse(Sr[5]);

        LEVEL = int.Parse(Sr[1])/10;
        HP += 10;
        MP += 10;
        ATTACK += 5;
        DEFENSE += 1;

        Sr[0] = LEVEL.ToString();
        Sr[2] = HP.ToString();
        Sr[3] = MP.ToString();
        Sr[4] = ATTACK.ToString();
        Sr[5] = DEFENSE.ToString();

        for (int i = 0; i < 6; i++)
        {
            string Ew = Sr[i];
            sw.WriteLine(Ew);
        }

        sw.Close();

        Avater.LEVEL += 1;
        Avater.HP += 10;
        Avater.MP += 10;
        Avater.ATTACK += 5;
        Avater.DEFENSE += 1;

    }

    public void Delete(Image ImageComponent)
    {
        if (ImageComponent.enabled)
        {
            ImageComponent.enabled = false;
        }
    }

    // Use this for initialization
    void Start () {
        ExpImage = GameObject.Find("Canvas/ExpImage");

        ExpImage.SetActive(false);
    }

    // Update is called once per frame
    void Update () {
		
	}
}
