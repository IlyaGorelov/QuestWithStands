
using TMPro;
using UnityEngine;

public class ShowLetter : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textCheck;
    [SerializeField] TextMeshProUGUI textReal;
    bool canChange=true;
    [SerializeField] AudioSource audioRight;
 
    bool canPlayWrong = true;
    void Update()
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
