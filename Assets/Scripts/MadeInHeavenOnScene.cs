using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MadeInHeavenOnScene : MonoBehaviour
{
    [SerializeField] AudioSource audioMIH;
    [SerializeField] Animator animMIH;
    void Update()
    {
        if (Properties.isMadeInHeaven)
        {
            Properties.isMadeInHeaven = false;
            audioMIH.Play();
            animMIH.SetTrigger("MIH");
            if(Properties.isPause)
                Time.timeScale = 3.0f;
            
        }
        if (!Properties.isPause)
            Time.timeScale = 1;
    }

    
}
