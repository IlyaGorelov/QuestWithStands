
using UnityEngine;

public class PlayMusic : MonoBehaviour
{
    [SerializeField] AudioSource audio;
    bool isPlay = false;
    public void Play()
    {
        if (!isPlay)
        {
            audio.Play();
            isPlay = true;
        }
        else
        {
            isPlay = false;
            audio.Pause();
        }
    }
}
