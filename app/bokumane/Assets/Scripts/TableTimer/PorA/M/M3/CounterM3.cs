using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;


public class CounterM3 : MonoBehaviour
{
    string keypM1 = "savepM3";
    public int pM1;
    public Text PcountM1;

    public void PlusOneP()
    {
        pM1 = PlayerPrefs.GetInt(keypM1, 0);
        bM1 = PlayerPrefs.GetInt(keybM1, 0);
        aM1 = PlayerPrefs.GetInt(keyaM1, 0);

        if ((pM1 + bM1 + aM1) < 15)
        {
            pM1 = pM1 + 1;
            PlayerPrefs.SetInt(keypM1, pM1);
            PlayerPrefs.Save();
            string strpM1 = pM1.ToString();
            PcountM1.text = strpM1;
        }
        else
        {
            pM1 = 0;
            PlayerPrefs.SetInt(keypM1, pM1);
            PlayerPrefs.Save();
            string strpM1 = pM1.ToString();
            PcountM1.text = strpM1;
        }

    }

    string keybM1 = "savebM3";
    public int bM1;
    public Text BcountM1;

    public void PlusOneB()
    {
        pM1 = PlayerPrefs.GetInt(keypM1, 0);
        bM1 = PlayerPrefs.GetInt(keybM1, 0);
        aM1 = PlayerPrefs.GetInt(keyaM1, 0);

        if ((pM1 + bM1 + aM1) < 15)
        {
            bM1 = bM1 + 1;
            PlayerPrefs.SetInt(keybM1, bM1);
            PlayerPrefs.Save();
            string strbM1 = bM1.ToString();
            BcountM1.text = strbM1;
        }
        else
        {
            bM1 = 0;
            PlayerPrefs.SetInt(keybM1, bM1);
            PlayerPrefs.Save();
            string strbM1 = bM1.ToString();
            BcountM1.text = strbM1;
        }

    }

    string keyaM1 = "saveaM3";
    public int aM1;
    public Text AcountM1;

    public void PlusOneA()
    {
        pM1 = PlayerPrefs.GetInt(keypM1, 0);
        bM1 = PlayerPrefs.GetInt(keybM1, 0);
        aM1 = PlayerPrefs.GetInt(keyaM1, 0);

        if ((pM1 + bM1 + aM1) < 15)
        {
            aM1 = aM1 + 1;
            PlayerPrefs.SetInt(keyaM1, aM1);
            PlayerPrefs.Save();
            string straM1 = aM1.ToString();
            AcountM1.text = straM1;
        }
        else
        {
            aM1 = 0;
            PlayerPrefs.SetInt(keyaM1, aM1);
            PlayerPrefs.Save();
            string straM1 = aM1.ToString();
            AcountM1.text = straM1;
        }

    }

    // Use this for initialization
    void Start()
    {
        pM1 = PlayerPrefs.GetInt(keypM1, 0);
        string strpM1 = pM1.ToString();
        PcountM1.text = strpM1;

        bM1 = PlayerPrefs.GetInt(keybM1, 0);
        string strbM1 = bM1.ToString();
        BcountM1.text = strbM1;

        aM1 = PlayerPrefs.GetInt(keyaM1, 0);
        string straM1 = aM1.ToString();
        AcountM1.text = straM1;
    }

    // Update is called once per frame
    void Update()
    {

    }
}