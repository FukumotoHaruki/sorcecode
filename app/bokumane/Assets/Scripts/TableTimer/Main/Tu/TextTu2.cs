using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text;
using System.IO;

public class TextTu2 : MonoBehaviour
{
    public Text textM1_4;

    // Use this for initialization
    void Start()
    {
        StreamReader srM1 = new StreamReader("saveDataTu2_1.txt", Encoding.GetEncoding("UTF-8"));

        string[] M1r = new string[7];
        for (int j = 0; j < 7; j++)
        {
            string line = srM1.ReadLine();
            M1r[j] = line;
        }

        textM1_4.text = M1r[3];


        // StreamReaderを閉じる
        srM1.Close();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
