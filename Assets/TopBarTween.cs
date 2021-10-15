using UnityEngine;

public class TopBarTween : MonoBehaviour
{
    public Transform topBar;
    void OnEnable()
    {
        topBar.localPosition = new Vector2(0, Screen.height);
        topBar.LeanMoveLocalY(498, 0.5f).setEaseInOutExpo().delay = 0.1f;  
    }
}
