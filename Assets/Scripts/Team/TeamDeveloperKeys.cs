
using UnityEngine;

public class TeamDeveloperKeys : MonoBehaviour
{
    [SerializeField] GameObject[] developerKeys;
    bool isDeveloperMode = false;
    void Start()
    {
        foreach (var key in developerKeys) 
        {
            key.SetActive(false);
        }
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F1) && !isDeveloperMode)
        {
            isDeveloperMode = true;
            foreach (var key in developerKeys)
            {
                key.SetActive(true);
            }
        }
        else if (Input.GetKeyDown(KeyCode.F1) && isDeveloperMode)
        {
            isDeveloperMode = false;
            foreach (var key in developerKeys)
            {
                key.SetActive(false);
            }
        }

    }
}
