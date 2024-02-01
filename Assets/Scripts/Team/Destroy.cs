using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public bool isGER=false;
    [SerializeField] Animator anim;
    [SerializeField] AudioSource audio;
    [SerializeField] GameObject WOU;
    [SerializeField] GameObject LoveTrain;
    private void Update()
    {
        if (isGER)
        {
            audio.Play();
            anim.SetTrigger("GER");
            isGER = false;
            WOU.SetActive(false);
            LoveTrain.SetActive(false);
        }
    }
}
