using UnityEngine;

public class RightPanelTween : MonoBehaviour
{
    public Transform rightPanel, button, topBar;
   // public RectTransform topBar;
    private void OnEnable()
    {
        rightPanel.localPosition = new Vector2(Screen.width, 0);
        rightPanel.LeanMoveLocalX(685, 0.5f).setEaseInOutExpo().delay = 0.1f;

        topBar.localPosition = new Vector2(0, Screen.height);
        topBar.LeanMoveLocalY(-44, 0.5f).setEaseInOutExpo().delay = 0.1f;

        //button.LeanMoveLocal(new Vector2(255, 1),1).setEaseOutQuart().setLoopPingPong();
    }

    
   /* public void CloseRightPanel()
    {
        box.LeanMoveLocalX(0.2f, Screen.width).setEaseInExpo();
            
    }*/
}
