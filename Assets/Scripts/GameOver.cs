using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public Text score, highScore;


    // Start is called before the first frame update
    void Start()
    {
        OnClickAd();
    }
    public void OnClickAd()
    {
        score.text = Collectables.score.ToString();
        highScore.text = Collectables.highScore.ToString();

    }
   
}
