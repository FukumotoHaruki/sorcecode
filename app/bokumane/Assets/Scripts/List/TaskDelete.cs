using UnityEngine;
using System.Collections;
using TodoApp;
using UnityEngine.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

public class TaskDelete : MonoBehaviour
{
    public TaskApp app;
    public Task targetTask;

    private int LEVEL;
    public static int EXP;

    public static int HP;
    public static int MP;
    public static int ATTACK;
    public static int DEFENSE;

    public void DeleteTrigger()
    {
        var toggle = this.GetComponentInChildren<Toggle>();
        if (toggle.isOn)
        {
            app.Tasks.Remove(this.targetTask);
            app.Save();

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

            EXP += 1;

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
        this.transform.SetParent(null);
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

        LEVEL += 1;
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

    public void Start()
    {
        
    }

    public void SetApp(TaskApp app)
    {
        this.app = app;
    }

    public void SetTargetTask(Task targetTask)
    {
        this.targetTask = targetTask;
    }
}
