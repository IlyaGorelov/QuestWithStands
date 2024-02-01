using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class changeQueueTextColor : MonoBehaviour
{
    TextMeshProUGUI text;
    void Start()
    {
        text=GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Properties.isFieldOfWonders)
        {
            text.color = Color.black;
        }
        else
        {
            text.color = Color.white;
        }
    }
}
