using System;
using TMPro;
using UnityEngine;

public class GetCountOfTeams : MonoBehaviour
{
    
    TMP_InputField inputField;
    public void SetCount()
    {
        inputField = GetComponent<TMP_InputField>();
        Properties.countOfTeams=Convert.ToInt32(inputField.text);
    }
}
