using UnityEngine;
using UnityEngine.UI;

public class PlayerName : MonoBehaviour
{
    public static PlayerName instance;
    public GameObject levelPanel;
    public GameObject menuPanel;
    public InputField playerName;
    public Text errorMsg;
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
    void Start()
    {
        playerName.text = PlayerPrefs.GetString("");
        GameConstants.PlayerName = playerName.text;
    }
    private void OnEnable()
    {
        playerName.onValueChanged.AddListener(delegate { SetName(); CheckEmpty();});
    }
    void SetName()
    {
        PlayerPrefs.SetString("", playerName.text);
        GameConstants.PlayerName = playerName.text;
        //Debug.Log("name: " + playerName.text);

        //CommonMethods.ShowLog("name: " + playerName.text);
    }
    public void NameCheck()
    {
        if (GameConstants.PlayerName == "")
        {
            menuPanel.SetActive(true);
            levelPanel.SetActive(false);
            errorMsg.text = "Please! Enter your name";
        }
        else
        {
            menuPanel.SetActive(false);
            levelPanel.SetActive(true);
        }
    }
    public void CheckEmpty()
    {
        errorMsg.text = "";
    }   
}
