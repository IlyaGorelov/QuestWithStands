using UnityEngine;

public class GoBeyondOnScene : MonoBehaviour
{
    [SerializeField] private AudioSource audioSAW;
    [SerializeField] private Animator animator;
    private void Update()
    {
        if (Properties.activateSAW)
        {
            audioSAW.Play();
            animator.SetTrigger("SAW");
            Properties.activateSAW = false;
        }
    }
}
