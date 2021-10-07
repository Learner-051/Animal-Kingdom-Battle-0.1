using UnityEngine;

public class FootStepsSound : MonoBehaviour
{
    public AudioSource source;
    public AudioClip clip;
   public void Walking()
    {
        source.PlayOneShot(clip);
    }
}
