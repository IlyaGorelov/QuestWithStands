using System;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    string name;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        name=collision.gameObject.name;
        Debug.Log(name);
        Properties.activeField = name;
    }
}
