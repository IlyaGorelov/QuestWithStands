using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activateFieldOfWonders : MonoBehaviour
{
    public void Activate()
    {
        Properties.isFieldOfWonders = true;
        Properties.isFieldEnd = false;
    }
    public void Deactivate()
    {
        Properties.isFieldOfWonders = false;
        Properties.isFieldEnd = true;
    }
}
