using System;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class Score
{
    public string pName;
    public int newScore;
    public Score(string pName, int newScore)
    {
        this.pName = pName;
        this.newScore = newScore;
    }
}