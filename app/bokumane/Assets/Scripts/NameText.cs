using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text;
using System.IO;

public class NameText : MonoBehaviour
{
   public Text Name;

    // Use this for initialization
    void Start()
    { 
        
        StreamReader sr = new StreamReader("Name.txt", Encoding.GetEncoding("UTF-8"));

        string[] N = new string[1];
        for (int j = 0; j < 1; j++)
        {
            string line = sr.ReadLine();
            N[j] = line;
        }

        Name.text = N[0];


        // StreamReaderを閉じる
        sr.Close();
    }

    // Update is called once per frame
    void Update()
    {

    }
}