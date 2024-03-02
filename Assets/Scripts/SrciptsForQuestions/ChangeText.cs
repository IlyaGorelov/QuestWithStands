using TMPro;
using UnityEngine;

public class ChangeText : MonoBehaviour
{
    public bool canChange = false;
    [SerializeField] private TextMeshProUGUI text;
    [SerializeField] private string newText;
    [SerializeField] private AudioSource audioD4C;
    [SerializeField] private Animator animD4C;

    private void Update()
    {
        if (canChange || Properties.canChange)
        {
            text.text = newText;
            audioD4C.Play();
            animD4C.SetTrigger("D4C");
            canChange = false;
            Properties.canChange = false;
        }
    }
}
