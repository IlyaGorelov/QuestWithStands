using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fieldsOfWonderEnd : MonoBehaviour
{
   public void Change()
    {
        Properties.isFieldEnd = true;
        Properties.isFieldOfWonders = false;
        Properties.activeLetter = "";
    }
}
