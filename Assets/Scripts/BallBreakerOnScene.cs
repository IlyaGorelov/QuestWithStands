using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBreakerOnScene : MonoBehaviour
{
    [SerializeField] AudioSource audioSAW;
    [SerializeField] Animator animator;
    void Update()
    {
        if (Properties.activateBallBreaker)
        {
            audioSAW.Play();
            animator.SetTrigger("BB");
            Properties.activateBallBreaker = false;
        }
    }
}
