using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text;
using System.IO;

public class Tuesday : MonoBehaviour
{
    Button PButton;
    Button AButton;
    Button BButton;

    // Use this for initialization
    void Start()
    {
        if ("" + System.DateTime.Now.DayOfWeek != "Tuesday")
        {
            PButton = GameObject.Find("Canvas/PButton").GetComponent<Button>();
            PButton.enabled = false;

            AButton = GameObject.Find("Canvas/AButton").GetComponent<Button>();
            AButton.enabled = false;

            BButton = GameObject.Find("Canvas/BButton").GetComponent<Button>();
            BButton.enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
