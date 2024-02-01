using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoBeyondOnScene : MonoBehaviour
{
    [SerializeField] AudioSource audioSAW;
    [SerializeField] Animator animator;
    void Update()
    {
        if(Properties.activateSAW)
        {
            audioSAW.Play();
            animator.SetTrigger("SAW");
            Properties.activateSAW = false;
        }
    }
}
