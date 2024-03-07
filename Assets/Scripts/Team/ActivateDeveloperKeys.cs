using UnityEngine;

public class ActivateDeveloperKeys : MonoBehaviour
{
    [SerializeField] private GameObject[] developerKeys;

    private void Start()
    {
        foreach (var key in developerKeys)
        {
            key.SetActive(false);
        }
    }

    private void Update()
    {
        if (Properties.isDeveloperMode)
        {
            foreach (var key in developerKeys)
            {
                key.SetActive(true);
            }
        }
        else if (!Properties.isDeveloperMode)
        {
            foreach (var key in developerKeys)
            {
                key.SetActive(false);
            }
        }
    }
}
