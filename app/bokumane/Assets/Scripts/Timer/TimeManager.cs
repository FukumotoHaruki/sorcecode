﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TimeManager : MonoBehaviour
{

    private const int maxTimeValue = 5999;

    [SerializeField] private UIManager uiManager;
    private float restTime;
    private bool isRunning;
    float x;

    // 初期化
    void Awake()
    {
        restTime = 0;
        UpdateTime();
        x = 0;
    }

    // タイマーの更新
    void Update()
    {
        if (isRunning)
        {
            restTime -= Time.deltaTime;
            x += Time.deltaTime;
            if (restTime <= 0)
            {
                uiManager.FinishTimer();
                StopTimer();
            }
            UpdateTime();
        }
    }

    // フッターのボタンの挙動
    public void FooterButton()
    {
        if (isRunning)
        {
            StopTimer();
        }
        else
        {
            StartTimer();
        }
        UpdateTime();
    }

    // タイマーのスタート
    public void StartTimer()
    {
        isRunning = true;
        uiManager.StartTimer();
    }

    // タイマーの一時停止
    public void PauseTimer()
    {
        isRunning = false;
    }

    // タイマーのストップ
    public void StopTimer()
    {
        PauseTimer();
        uiManager.StopTimer();
        uiManager.TimerExpGet(x);
        uiManager.TimerExpText(x);
    }

    // タイマーの更新
    private void UpdateTime()
    {
        uiManager.UpdateTime(restTime);
    }

    // タイマーの時間設定
    public void AddSec(int value)
    {
        restTime += value;
        restTime = Mathf.Clamp(restTime, 0, maxTimeValue);
        UpdateTime();
    }
}
