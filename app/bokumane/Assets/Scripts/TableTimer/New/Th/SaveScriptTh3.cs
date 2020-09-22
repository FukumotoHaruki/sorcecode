using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text;
using System.IO;


public class SaveScriptTh3 : MonoBehaviour
{

    //1行目のinputfiled
    string strM1_1;
    public InputField inputFieldM1_1;
    public Text textM1_1;

    public void SaveTextM1_1()
    {
        strM1_1 = inputFieldM1_1.text;
        inputFieldM1_1.text = "";
    }

    //2行目のinputfiled
    string strM1_2;
    public InputField inputFieldM1_2;
    public Text textM1_2;

    public void SaveTextM1_2()
    {
        strM1_2 = inputFieldM1_2.text;
        inputFieldM1_2.text = "";
    }

    //3行目のinputfiled
    string strM1_3;
    public InputField inputFieldM1_3;
    public Text textM1_3;

    public void SaveTextM1_3()
    {
        strM1_3 = inputFieldM1_3.text;
        inputFieldM1_3.text = "";
    }

    //4行目のinputfiled
    string strM1_4;
    public InputField inputFieldM1_4;
    public Text textM1_4;

    public void SaveTextM1_4()
    {
        strM1_4 = inputFieldM1_4.text;
        inputFieldM1_4.text = "";
    }

    //5行目のinputfiled
    string strM1_5;
    public InputField inputFieldM1_5;
    public Text textM1_5;

    public void SaveTextM1_5()
    {
        strM1_5 = inputFieldM1_5.text;
        inputFieldM1_5.text = "";
    }

    //6行目のinputfiled
    string strM1_6;
    public InputField inputFieldM1_6;
    public Text textM1_6;

    public void SaveTextM1_6()
    {
        strM1_6 = inputFieldM1_6.text;
        inputFieldM1_6.text = "";
    }

    //7行目のinputfiled
    string strM1_7;
    public InputField inputFieldM1_7;
    public Text textM1_7;

    public void SaveTextM1_7()
    {
        strM1_7 = inputFieldM1_7.text;
        inputFieldM1_7.text = "";
    }

    // Use this for initialization
    public void SaveInputfield()
    {

        string[] M1w = new string[7];
        M1w[0] = strM1_1;
        M1w[1] = strM1_2;
        M1w[2] = strM1_3;
        M1w[3] = strM1_4;
        M1w[4] = strM1_5;
        M1w[5] = strM1_6;
        M1w[6] = strM1_7;

        // ファイル書き出し
        // 現在のフォルダにsaveData.csvを出力する(決まった場所に出力したい場合は絶対パスを指定してください)
        // 引数説明：第1引数→ファイル出力先, 第2引数→ファイルに追記(true)or上書き(false), 第3引数→エンコード
        StreamWriter sw = new StreamWriter(@"saveDataTh3_1.txt", false, Encoding.GetEncoding("UTF-8"));

        for (int i = 0; i < 7; i++)
        {
            string MM1 = M1w[i];
            sw.WriteLine(MM1);
        }
        // StreamWriterを閉じる
        sw.Close();

    }

    void Start()
    {
        // ファイル読み込み
        StreamReader srM1 = new StreamReader("saveDataTh3_1.txt", Encoding.GetEncoding("UTF-8"));

        string[] M1r = new string[7];
        for (int j = 0; j < 7; j++)
        {
            string line = srM1.ReadLine();
            M1r[j] = line;
        }
        inputFieldM1_1.text = M1r[0];
        inputFieldM1_2.text = M1r[1];
        inputFieldM1_3.text = M1r[2];
        inputFieldM1_4.text = M1r[3];
        inputFieldM1_5.text = M1r[4];
        inputFieldM1_6.text = M1r[5];
        inputFieldM1_7.text = M1r[6];

        // StreamReaderを閉じる
        srM1.Close();
    }


    // Update is called once per frame
    void Update()
    {

    }
}
