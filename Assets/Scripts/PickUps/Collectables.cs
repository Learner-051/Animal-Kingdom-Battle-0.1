using UnityEngine;
using UnityEngine.UI;
using System;
public class Collectables : MonoBehaviour
{
    public static int score;
    public static int highScore;
    [SerializeField] int countDownStartValue = 60;
    public Text scoreText;
    public Text highScoreText;
    public Text timer;
    public GameObject gameover;
    public GameObject gameWin;
    public GameObject checkTime;
    public AudioClip effect;
    public AudioSource audioSource;


    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        InvokeRepeating("SetScore", 0, 1f);
        score = 0;
        highScore = PlayerPrefs.GetInt("highScore");
        highScoreText.text = highScore.ToString();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Collectables"))
        {
            other.gameObject.SetActive(false);
            score += 10;
            SetScore();
            audioSource.PlayOneShot(effect, 0.7f);
        }
    }
    private void SetScore()
    {
        scoreText.text = score.ToString();
        highScoreText.text = highScore.ToString();
        if (score > PlayerPrefs.GetInt("highScore"))
        {
            PlayerPrefs.SetInt("highScore", score);
            highScoreText.text = score.ToString();
        }
        if (countDownStartValue > 0)
        {
            TimeSpan spanTime = TimeSpan.FromSeconds(countDownStartValue);
            timer.text = "Time : " + spanTime.Minutes + " : " + spanTime.Seconds;
            if (checkTime.active == true)
            {
                countDownStartValue--;
            }

        }
        else if (score >= 50)
        {
            gameWin.SetActive(true);
            //audioSource.PlayOneShot(winnersound, 0.7F);
            CancelInvoke("SetScore");
        }
        else
        {
            gameover.SetActive(true);
            CancelInvoke("SetScore");
        }
    }
    public static void DoubleScore()
    {
        score *= 2;

    }
}


