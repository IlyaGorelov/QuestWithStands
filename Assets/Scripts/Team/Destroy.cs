using UnityEngine;

public class Destroy : MonoBehaviour
{
    public bool isGER = false;
    [SerializeField] private Animator anim;
    [SerializeField] private AudioSource audio;
    [SerializeField] private GameObject WOU;
    [SerializeField] private GameObject LoveTrain;

    private void Update()
    {
        if (isGER)
        {
            audio.Play();
            anim.SetTrigger("GER");
            isGER = false;
            WOU.SetActive(false);
            LoveTrain.SetActive(false);
        }
    }
}
