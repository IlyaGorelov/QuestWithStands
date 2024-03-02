using UnityEngine;

public class MadeInHeavenOnScene : MonoBehaviour
{
    [SerializeField] private AudioSource audioMIH;
    [SerializeField] private Animator animMIH;
    private void Update()
    {
        if (Properties.isMadeInHeaven)
        {
            Properties.isMadeInHeaven = false;
            audioMIH.Play();
            animMIH.SetTrigger("MIH");
            if (Properties.isPause)
                Time.timeScale = 3.0f;
        }
        if (!Properties.isPause)
            Time.timeScale = 1;
    }
}
