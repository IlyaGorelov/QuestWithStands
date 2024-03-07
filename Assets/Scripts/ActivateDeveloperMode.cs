using UnityEngine;

public class ActivateDeveloperMode : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F1) && Properties.isDeveloperMode)
        {
            Properties.isDeveloperMode = false;
        }
        else if(Input.GetKeyDown(KeyCode.F1) && !Properties.isDeveloperMode)
        {
            Properties.isDeveloperMode = true;
        }
    }
}
