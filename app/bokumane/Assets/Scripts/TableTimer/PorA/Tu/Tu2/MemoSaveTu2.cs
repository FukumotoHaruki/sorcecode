using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text;
using System.IO;

public class MemoSaveTu2 : MonoBehaviour
{

    string strMemoM1;
    public InputField inputFieldMemoM1;
    public Text textMemoM1;

    public void Memo1()
    {
        strMemoM1 = inputFieldMemoM1.text;
        inputFieldMemoM1.text = "";
    }

    public void SaveMemo()
    {
        string[] MemoM1w = new string[1];
        MemoM1w[0] = strMemoM1;

        StreamWriter sw = new StreamWriter(@"saveMemoTu2_1.txt", false, Encoding.GetEncoding("UTF-8"));

        string MEMOM1 = MemoM1w[0];
        sw.WriteLine(MEMOM1);

        sw.Close();
    }

    // Use this for initialization
    void Start()
    {
        StreamReader srM1 = new StreamReader("saveMemoTu2_1.txt", Encoding.GetEncoding("UTF-8"));

        string[] MemoM1r = new string[1];
        string line = srM1.ReadLine();
        MemoM1r[0] = line;
        inputFieldMemoM1.text = MemoM1r[0];

        srM1.Close();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
