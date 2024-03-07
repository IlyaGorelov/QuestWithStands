using UnityEngine;

public class GoBeyond : MonoBehaviour
{
    [SerializeField] private GameObject closeArea;

    public void canDoGoBeyond()
    {
        Properties.activateSAW = true;
        Properties.LockWouForever = true;
    }

    private void Update()
    {
        if (Properties.LockWouForever)
            closeArea.SetActive(true);
    }
}
