﻿using UnityEngine;
using UnityEngine.UI;

public class PlayerName : MonoBehaviour
{
    public static PlayerName instance;
    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
    }

    public InputField playerName;
    void Start()
    {
        playerName.text = PlayerPrefs.GetString("PlayerName");
        GameContants.PlayerName = playerName.text;
    }

    private void OnEnable()
    {
        playerName.onValueChanged.AddListener(delegate { SetName(); });
    }

    void SetName()
    {
        PlayerPrefs.SetString("PlayerName", playerName.text);
        GameContants.PlayerName = playerName.text;
        Debug.Log("name: " + playerName.text);
    }
}
