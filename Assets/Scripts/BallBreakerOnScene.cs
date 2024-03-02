using UnityEngine;

public class BallBreakerOnScene : MonoBehaviour
{
    [SerializeField] private AudioSource audioSAW;
    [SerializeField] private Animator animator;

    private void Update()
    {
        if (Properties.activateBallBreaker)
        {
            audioSAW.Play();
            animator.SetTrigger("BB");
            Properties.activateBallBreaker = false;
        }
    }
}
