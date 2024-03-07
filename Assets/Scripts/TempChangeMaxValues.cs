
using System;
using TMPro;
using UnityEngine;

public class TempChangeMaxValues : MonoBehaviour
{
    TMP_InputField inputField;

    private void Start()
    {
        inputField = GetComponent<TMP_InputField>();
    }

    public void changeD4c()
    {
        Properties.maxD4CLT = Int32.Parse(inputField.text);
        if (Properties.maxD4CLT < 500)
            Properties.maxD4CLT = 500;
    }
    public void changeWou()
    {
        Properties.maxWOU = Int32.Parse(inputField.text);
        if (Properties.maxWOU < 500)
            Properties.maxWOU = 500;
    }
}
