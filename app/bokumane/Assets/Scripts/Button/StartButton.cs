using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text;
using System.IO;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    

    /// ボタンをクリックした時の処理
    public void SceneLoad()
    {
        string Ntext;
        StreamReader srN = new StreamReader("Name.txt", Encoding.GetEncoding("UTF-8"));

        string[] N = new string[1];
        for (int j = 0; j < 1; j++)
        {
            string line = srN.ReadLine();
            N[j] = line;
        }

        Ntext = N[0];

        if (Ntext == "")
        {
            SceneManager.LoadScene("NameScene");
        }
        else
        {
            SceneManager.LoadScene("StatusScene");
        }
        // StreamReaderを閉じる
        srN.Close();
    }
}


