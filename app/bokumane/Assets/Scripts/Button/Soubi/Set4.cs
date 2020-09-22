using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text;
using System.IO;

public class Set4 : MonoBehaviour
{

    public void Set()
    {
        string[] W = new string[41];

        StreamReader srW = new StreamReader("DropData.txt", Encoding.GetEncoding("UTF-8"));
        for (int i = 0; i < 41; i++)
        {

            string line = srW.ReadLine();
            W[i] = line;
        }
        // StreamReaderを閉じる
        srW.Close();

        StreamWriter sw = new StreamWriter(@"DropData.txt", false, Encoding.GetEncoding("UTF-8"));
        string[] Sw = new string[41];
        for (int j = 0; j < 41; j++)
        {
            Sw[j] = W[j];
        }

        Sw[40] = "8";

        for (int i = 0; i < 41; i++)
        {
            string Ew = Sw[i];
            sw.WriteLine(Ew);
        }

        sw.Close();

        Avater.WEAR = 8;
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
