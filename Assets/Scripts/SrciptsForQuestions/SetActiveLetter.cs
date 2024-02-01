using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetActiveLetter : MonoBehaviour
{
    bool canClick = false;
    [SerializeField] GameObject cross;

    private void Update()
    {
        if (canClick)
        {
            if(Input.GetMouseButtonDown(0)) 
            {
                Properties.activeLetter=gameObject.name;
                Debug.Log(Properties.activeLetter);
                cross.SetActive(true);
            }
        }
    }
    private void OnMouseEnter()
    {
        canClick = true;
    }

    private void OnMouseExit()
    {
        canClick = false;
    }
}
