using UnityEngine;

public class BallBreaker : MonoBehaviour
{
    [SerializeField] GameObject closeArea;

    public void canDoBallBreaker()
    {
        Properties.activateBallBreaker = true;
        Properties.LockD4CForever = true;
    }

    private void Update()
    {
        if (Properties.LockD4CForever)
            closeArea.SetActive(true);
    }
}
