using UnityEngine;
public static class GameConstants
{
    public static string PlayerName = "";
    public static string characterSelected = "CharacterSelected";
    public static string highScore = "highScore";
    //public static string score = "scores";
}

static class CommonMethods
{

    static bool IsDevMode = false;

    public static void ShowLog(string msg)
    {

        if (IsDevMode)
        {
            Debug.Log(msg);
        }


    }
}
