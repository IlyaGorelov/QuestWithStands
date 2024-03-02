using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioControl : MonoBehaviour
{
    [SerializeField] private AudioMixer audioMixer;
    private Slider slider;

    private enum type
    {
        music,
        stand
    };

    [SerializeField] private type thisType;

    private void Start()
    {
        slider = GetComponent<Slider>();
    }

    public void changeVolume()
    {
        if (thisType == type.music)
            audioMixer.SetFloat("MusicVolume", slider.value);
        if (thisType == type.stand)
            audioMixer.SetFloat("StandVolume", slider.value);
    }
}
