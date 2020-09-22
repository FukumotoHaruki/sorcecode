using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text;
using System.IO;
using UnityEngine.SceneManagement;

public class NewPorAM3Button : MonoBehaviour
{
    public string M1text;

    /// ボタンをクリックした時の処理
    public void SceneLoad()
    {
        StreamReader srM1 = new StreamReader("saveDataM3_1.txt", Encoding.GetEncoding("UTF-8"));

        string[] M1r = new string[7];
        for (int j = 0; j < 7; j++)
        {
            string line = srM1.ReadLine();
            M1r[j] = line;
        }

        M1text = M1r[3];

        if (M1text == "")
        {
            SceneManager.LoadScene("NewM3Scene");
        }
        else
        {
            SceneManager.LoadScene("PorAM3");
        }
        // StreamReaderを閉じる
        srM1.Close();
    }
}
