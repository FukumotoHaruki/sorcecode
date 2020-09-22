using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text;
using System.IO;

public class Wednesday : MonoBehaviour
{
    Button PButton;
    Button AButton;
    Button BButton;

    // Use this for initialization
    void Start()
    {
        if ("" + System.DateTime.Now.DayOfWeek != "Wednesday")
        {
            PButton = GameObject.Find("Canvas/PButton").GetComponent<Button>();
            PButton.enabled = false;

            AButton = GameObject.Find("Canvas/AButton").GetComponent<Button>();
            AButton.enabled = false;

            BButton = GameObject.Find("Canvas/BButton").GetComponent<Button>();
            BButton.enabled = false;
        }
        else
        {
            PButton = GameObject.Find("Canvas/PButton").GetComponent<Button>();
            PButton.enabled = true;

            AButton = GameObject.Find("Canvas/AButton").GetComponent<Button>();
            AButton.enabled = true;

            BButton = GameObject.Find("Canvas/BButton").GetComponent<Button>();
            BButton.enabled = true;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}