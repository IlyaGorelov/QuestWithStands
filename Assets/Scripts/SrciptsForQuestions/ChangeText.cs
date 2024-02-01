
using TMPro;
using UnityEngine;

public class ChangeText : MonoBehaviour
{
    public bool canChange = false;
    [SerializeField] TextMeshProUGUI text;
    [SerializeField] string newText;
    [SerializeField] AudioSource audioD4C;
    [SerializeField] Animator animD4C;
    private void Update()
    {
        if (canChange|| Properties.canChange)
        {
            text.text = newText;
            audioD4C.Play();
            animD4C.SetTrigger("D4C");
            canChange=false;
            Properties.canChange = false;
        }
    }
}
