﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimetableButton : MonoBehaviour
{

    /// ボタンをクリックした時の処理
    public void SceneLoad()
    {
        SceneManager.LoadScene("TimetableScene");
    }
}