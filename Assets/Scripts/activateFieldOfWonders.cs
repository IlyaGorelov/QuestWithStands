using UnityEngine;

public class ActivateFieldOfWonders : MonoBehaviour
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
