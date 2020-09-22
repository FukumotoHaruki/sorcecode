using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text;
using System.IO;

public class TextManagerW1 : MonoBehaviour
{

    public Text textM1_1;
    public Text textM1_4;
    public Text textM1_5;
    public Text textM1_6;

    // Use this for initialization
    void Start()
    {
        StreamReader srM1 = new StreamReader("saveDataW1_1.txt", Encoding.GetEncoding("UTF-8"));

        string[] M1r = new string[7];
        for (int j = 0; j < 7; j++)
        {
            string line = srM1.ReadLine();
            M1r[j] = line;
        }

        textM1_1.text = M1r[0];
        textM1_4.text = M1r[3];
        textM1_5.text = M1r[4];
        textM1_6.text = M1r[5];


        // StreamReaderを閉じる
        srM1.Close();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
