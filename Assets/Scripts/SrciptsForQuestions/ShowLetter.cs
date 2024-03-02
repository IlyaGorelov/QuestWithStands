using TMPro;
using UnityEngine;

public class ShowLetter : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textCheck;
    [SerializeField] private TextMeshProUGUI textReal;
    private bool canChange = true;
    [SerializeField] private AudioSource audioRight;
    private bool canPlayWrong = true;

    private void Update()
    {
        if (Properties.activeLetter == textCheck.text)
        {
            if (canChange)
            {
                canChange = false;
                Properties.isRightLetter = true;
                Properties.canAddToField = true;
                audioRight.Play();
            }
            textReal.text = textCheck.text;
            Debug.Log(Properties.canAdd);
        }
    }
}
