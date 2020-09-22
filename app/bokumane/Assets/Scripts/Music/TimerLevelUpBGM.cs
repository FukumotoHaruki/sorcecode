using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text;
using System.IO;

public class TimerLevelUpBGM : MonoBehaviour
{
    public AudioSource AS;
    public AudioClip A;
    
    void Start()
    {
        AS = GetComponent<AudioSource>();

        StreamReader sr = new StreamReader("StatusData.txt", Encoding.GetEncoding("UTF-8"));
        string[] Sr = new string[6];
        for (int j = 0; j < 6; j++)
        {
            string line = sr.ReadLine();
            Sr[j] = line;
        }

        sr.Close();

        int x = int.Parse(Sr[1]);

        if ((x % 10) == 0){
            AS.PlayOneShot(A);
        }
    }


    // Update is called once per frame
    void Update()
    {

    }
}
