using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Text;
using System.IO;

public class ExpBar : MonoBehaviour {

    Slider _slider;
    void Start()
    {
        StreamReader sr = new StreamReader("StatusData.txt", Encoding.GetEncoding("UTF-8"));
        string[] Sr = new string[6];
        for (int j = 0; j < 6; j++)
        {
            string line = sr.ReadLine();
            Sr[j] = line;
        }

        sr.Close();

        int expgauge = int.Parse(Sr[1]);

        int e = expgauge % 10;
        // スライダーを取得する
        _slider = GameObject.Find("Slider").GetComponent<Slider>();

        _slider.value = e;
    }
    
    void Update()
    {

    }
}
