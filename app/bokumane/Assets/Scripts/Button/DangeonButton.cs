using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DangeonButton : MonoBehaviour
{
    /// ボタンをクリックした時の処理
    public void SceneLoad()
    {
        SceneManager.LoadScene("DangeonScene");
    }
}
