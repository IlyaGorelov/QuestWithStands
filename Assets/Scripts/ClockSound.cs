using UnityEngine;

public class ClockSound : MonoBehaviour
{
    public AudioSource[] audios;

    private void Start()
    {
        audios = GetComponents<AudioSource>();
    }
}
