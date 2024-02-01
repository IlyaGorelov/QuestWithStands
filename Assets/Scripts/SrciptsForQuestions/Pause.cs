
using UnityEngine;

public class Pause : MonoBehaviour
{
    public void DoPause()
    {
        Properties.isPause = true;
    }

    public void UndoPause()
    {
        Properties.isPause = false;
    }
}
