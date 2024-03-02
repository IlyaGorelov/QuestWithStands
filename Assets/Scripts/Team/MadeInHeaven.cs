using UnityEngine;

public class MadeInHeaven : MonoBehaviour
{
    [SerializeField] GameObject closeArea;

    public void DoMaidInHeaven()
    {
        closeArea.SetActive(true);
        Properties.isMadeInHeaven = true;
    }
}
