using UnityEngine;

public class BlockRaycast : MonoBehaviour
{
    [SerializeField] private GameObject raycastTarget;

    private void Update()
    {
        if (Properties.isPause)
        {
            raycastTarget.SetActive(true);
        }
        else
        {
            raycastTarget.SetActive(false);
        }
    }
}
