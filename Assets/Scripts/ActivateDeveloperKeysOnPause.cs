using UnityEngine;

public class ActivateDeveloperKeysOnPause : MonoBehaviour
{
    [SerializeField] GameObject[] buttons;
   private void Update()
    {
        if(Properties.isDeveloperMode)
        {
            foreach(GameObject button in buttons)
            {
                button.SetActive(true);
            }
        }
        else
        {
            foreach (GameObject button in buttons)
            {
                button.SetActive(false);
            }
        }
    }
}
