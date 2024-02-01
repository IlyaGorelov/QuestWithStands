using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GEROnScene : MonoBehaviour
{
    [SerializeField] Animator anim;
    void Update()
    {
        if (Properties.doGER)
        {
            anim.SetTrigger("GER");
            Properties.doGER = false;
        }
    }
}
