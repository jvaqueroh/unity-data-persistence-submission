using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    public static DataManager Instance;

    private long bestScore;
    private string bestPlayer;
    private string playerName;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }


    public void SetLastScore(int score)
    {
        if (score > Instance.bestScore)
        {
            bestScore = score;
            bestPlayer = playerName;
        }
    }

    public long GetBestScore() => Instance.bestScore;

    public string GetBestPlayer() => Instance.bestPlayer;

    public void SetPlayerName(string name)
    {
        Instance.playerName = name;
    }
}
