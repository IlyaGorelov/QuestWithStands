using UnityEngine;

public class BallBreaker : MonoBehaviour
{
    [SerializeField] GameObject closeArea;

    public void canDoBallBreaker()
    {
        Properties.activateBallBreaker = true;
        Properties.canDoD4C = false;
    }

    private void Update()
    {
        if (!Properties.canDoD4C)
            closeArea.SetActive(true);
    }
}
