using System.Linq;
using UnityEngine;

public class ScoreUI : MonoBehaviour
{
    public RowUI rowUI;
    //public ScoreManager scoreManager;
    private void Start()
    {
        //scoreManager.AddScore(new Score("Naila", 80));
        //scoreManager.AddScore(new Score("Amna", 100));

        var scores = ScoreManager.instance.GetHighScores().ToArray();
        for(int i=0; i< scores.Length; i++)
        {
            var row = Instantiate(rowUI, transform).GetComponent<RowUI>();
            row.rank.text = (i + 1).ToString();
            row.playerName.text = scores[i].pName;
            row.score.text = scores[i].newScore.ToString();
        }
    }
}
