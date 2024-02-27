using UnityEngine;
using TMPro;
using System;

public class SwitchResolution : MonoBehaviour
{
    [SerializeField] private TMP_Dropdown _Dropdown;
    public void ChangeResolution()
    { 
        string value = _Dropdown.options[_Dropdown.value].text;
        string[] resol = value.Split('x');
        Screen.SetResolution(Int32.Parse(resol[0]), Int32.Parse(resol[1]), true);
    }
}
