using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockRaycast : MonoBehaviour
{
    [SerializeField] private GameObject raycastTarget;
    // Update is called once per frame
    void Update()
    {
        if (Properties.isPause)
        {
            raycastTarget.SetActive(true);
        }
        else
        {
            raycastTarget.SetActive(false);
        }
    }
}
