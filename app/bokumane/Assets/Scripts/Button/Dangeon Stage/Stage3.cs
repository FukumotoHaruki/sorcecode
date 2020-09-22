using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Stage3 : MonoBehaviour
{

    /// ボタンをクリックした時の処理
    public void SceneLoad()
    {
        SceneManager.LoadScene("Battle3-1");

        Dungeon.DUNGEON = 3;
    }
}
