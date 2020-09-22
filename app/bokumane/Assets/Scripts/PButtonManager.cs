using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text;
using System.IO;

public class PButtonManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
        StreamReader sr = new StreamReader("Pcounter.txt", Encoding.GetEncoding("UTF-8"));
        string[] Sr = new string[25];
        for (int j = 0; j < 25; j++)
        {
            string line = sr.ReadLine();
            Sr[j] = line;
        }

        sr.Close();

        StreamWriter sw = new StreamWriter(@"Pcounter.txt", false, Encoding.GetEncoding("UTF-8"));
        string[] Sw = new string[25];
        for (int j = 0; j < 25; j++)
        {
            Sw[j] = Sr[j];
        }

        if ("" + System.DateTime.Now.DayOfWeek == "Monday")
        {
            for (int j = 5; j < 25; j++)
            {
                Sw[j] = 0.ToString();
            }
        }
        else if("" + System.DateTime.Now.DayOfWeek == "Tuesday")
        {
            for (int j = 0; j < 5; j++)
            {
                Sw[j] = 0.ToString();
            }
            for (int j = 10; j < 25; j++)
            {
                Sw[j] = 0.ToString();
            }
        }
        else if ("" + System.DateTime.Now.DayOfWeek == "Wednesday")
        {
            for (int j = 0; j < 10; j++)
            {
                Sw[j] = 0.ToString();
            }
            for (int j = 15; j < 25; j++)
            {
                Sw[j] = 0.ToString();
            }
        }
        else if ("" + System.DateTime.Now.DayOfWeek == "Thursday")
        {
            for (int j = 0; j < 15; j++)
            {
                Sw[j] = 0.ToString();
            }
            for (int j = 20; j < 25; j++)
            {
                Sw[j] = 0.ToString();
            }
        }
        else if ("" + System.DateTime.Now.DayOfWeek == "Friday")
        {
            for (int j = 0; j < 20; j++)
            {
                Sw[j] = 0.ToString();
            }
        }

        for (int i = 0; i < 25; i++)
        {
            string Ew = Sw[i];
            sw.WriteLine(Ew);
        }

        sw.Close();

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
