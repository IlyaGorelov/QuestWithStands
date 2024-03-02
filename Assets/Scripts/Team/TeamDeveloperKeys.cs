using UnityEngine;

public class TeamDeveloperKeys : MonoBehaviour
{
    [SerializeField] private GameObject[] developerKeys;
    private bool isDeveloperMode = false;

    private void Start()
    {
        foreach (var key in developerKeys)
        {
            key.SetActive(false);
        }
    }

    private void Update()
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
