
using UnityEngine;

public class GoBeyond : MonoBehaviour
{
    [SerializeField] GameObject closeArea;
    public void canDoGoBeyond()
    {
        Properties.activateSAW = true;
        Properties.canDoWOU = false;
    }

    private void Update()
    {
       if(!Properties.canDoWOU)
            closeArea.SetActive(true);
    }
}