using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    [SerializeField]
    private float delayBeforeLoading = 10f;
    private float timeElapsed;

    public enum SceneNames { Splash, Gameplay, MainMenu}
    public SceneNames SelectedScene = SceneNames.MainMenu;

    void Update()
    {
        timeElapsed += Time.deltaTime;
        if (timeElapsed > delayBeforeLoading)
        {
            SceneManager.LoadScene(SceneNames.MainMenu.ToString());
        }

    }
}