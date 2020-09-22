using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Stage2 : MonoBehaviour
{

    /// ボタンをクリックした時の処理
    public void SceneLoad()
    {
        SceneManager.LoadScene("Battle2-1");

        Dungeon.DUNGEON = 2;
    }
}
