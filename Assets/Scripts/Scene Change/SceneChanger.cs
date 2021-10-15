using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{	public enum SceneNames { Splash, Gameplay, MainMenu }
	public SceneNames SelectedScene = SceneNames.MainMenu;
    public void ToGameplay()
    {
		SceneManager.LoadScene(SceneNames.Gameplay.ToString());
	}
	public void ToMainMenu ()
	{
		SceneManager.LoadScene(SceneNames.MainMenu.ToString());
	}
	public void Exit()
	{
		Application.Quit();
	}
}