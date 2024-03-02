using UnityEngine;

public class GEROnScene : MonoBehaviour
{
    [SerializeField] private Animator anim;
    private void Update()
    {
        if (Properties.doGER)
        {
            anim.SetTrigger("GER");
            Properties.doGER = false;
        }
    }
}
