using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public Text score, highScore;
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
