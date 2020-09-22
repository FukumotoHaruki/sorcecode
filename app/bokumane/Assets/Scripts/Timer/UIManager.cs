using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;

public class UIManager : MonoBehaviour
{

    private int LEVEL;
    public static int EXP;

    public static int HP;
    public static int MP;
    public static int ATTACK;
    public static int DEFENSE;

    public Text text;

    [SerializeField] private Text timerText;
    [SerializeField] private Text footerButtonText;
    [SerializeField] private GameObject timerSettingButtons;
    [SerializeField] private GameObject finishPanel;

    public void UpdateTime(float time)
    {
        timerText.text = string.Format("{0:00}:{1:00}", (int)(time / 60), time % 60);
    }

    public void StartTimer()
    {
        timerSettingButtons.SetActive(false);
        footerButtonText.text = "STOP";
    }

    public void StopTimer()
    {
        footerButtonText.text = "START";
    }

    public void FinishTimer()
    {
        timerSettingButtons.SetActive(true);
        finishPanel.SetActive(true);
    }

    public void CloseFinishPanel()
    {
        finishPanel.SetActive(false);
    }

    public void TimerExpText(float x)
    {
        int Exp = (int)x/10;

        text.text = Exp.ToString();
    }

    public void TimerExpGet(float x)
    {
        StreamReader sr = new StreamReader("StatusData.txt", Encoding.GetEncoding("UTF-8"));
        string[] Sr = new string[6];
        for (int j = 0; j < 6; j++)
        {
            string line = sr.ReadLine();
            Sr[j] = line;
        }

        sr.Close();

        StreamWriter sw = new StreamWriter(@"StatusData.txt", false, Encoding.GetEncoding("UTF-8"));
        string[] Sw = new string[6];
        for (int j = 0; j < 6; j++)
        {
            Sw[j] = Sr[j];
        }

        EXP = int.Parse(Sw[1]);

        EXP += (int)x / 600;

        Sw[1] = EXP.ToString();

        for (int i = 0; i < 6; i++)
        {
            string Ew = Sw[i];
            sw.WriteLine(Ew);
        }

        sw.Close();

        Avater.EXP += 1;

        if (EXP % 10 == 0)
        {
            LEVELUP();
        }
    }

    public void LEVELUP()
    {
        StreamReader sr = new StreamReader("StatusData.txt", Encoding.GetEncoding("UTF-8"));
        string[] Sr = new string[6];
        for (int j = 0; j < 6; j++)
        {
            string line = sr.ReadLine();
            Sr[j] = line;
        }

        sr.Close();

        StreamWriter sw = new StreamWriter(@"StatusData.txt", false, Encoding.GetEncoding("UTF-8"));

        LEVEL = int.Parse(Sr[0]);
        HP = int.Parse(Sr[2]);
        MP = int.Parse(Sr[3]);
        ATTACK = int.Parse(Sr[4]);
        DEFENSE = int.Parse(Sr[5]);

        LEVEL = int.Parse(Sr[1]) / 10;
        HP += 10;
        MP += 10;
        ATTACK += 5;
        DEFENSE += 1;

        Sr[0] = LEVEL.ToString();
        Sr[2] = HP.ToString();
        Sr[3] = MP.ToString();
        Sr[4] = ATTACK.ToString();
        Sr[5] = DEFENSE.ToString();

        for (int i = 0; i < 6; i++)
        {
            string Ew = Sr[i];
            sw.WriteLine(Ew);
        }

        sw.Close();

        Avater.LEVEL += 1;
        Avater.HP += 10;
        Avater.MP += 10;
        Avater.ATTACK += 5;
        Avater.DEFENSE += 1;
        
    }
}
