using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text;
using System.IO;

public class NameSave : MonoBehaviour {

    string str;
    public Text text;

    public void Save()
    {
        str = text.text;
        string[] w = new string[1];
        w[0] = str;
        // ファイル書き出し
        // 現在のフォルダにsaveData.csvを出力する(決まった場所に出力したい場合は絶対パスを指定してください)
        // 引数説明：第1引数→ファイル出力先, 第2引数→ファイルに追記(true)or上書き(false), 第3引数→エンコード
        StreamWriter sw = new StreamWriter(@"Name.txt", false, Encoding.GetEncoding("UTF-8"));
        string N = w[0];
        sw.WriteLine(N);
        // StreamWriterを閉じる
        sw.Close();

    }

    // Use this for initialization
    void Start () {
        StreamReader srM1 = new StreamReader("Name.txt", Encoding.GetEncoding("UTF-8"));

        string[] M1r = new string[1];
        for (int j = 0; j < 1; j++)
        {
            string line = srM1.ReadLine();
            M1r[j] = line;
        }

        text.text = M1r[0];


        // StreamReaderを閉じる
        srM1.Close();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
