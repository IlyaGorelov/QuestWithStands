using System;
using TMPro;
using UnityEngine;

public class PlusScore : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI score;
    [SerializeField] private TMP_InputField Changescore;
    [SerializeField] private GameObject ChangeImage;

    public void Plus()
    {
        int old = Int32.Parse(score.text);
        int newScore = old + Int32.Parse(Changescore.text);
        score.text = newScore.ToString();
        ChangeImage.SetActive(false);
    }
    public void Minus()
    {
        int old = Int32.Parse(score.text);
        int newScore = old - Int32.Parse(Changescore.text);
        score.text = newScore.ToString();
        ChangeImage.SetActive(false);
    }
}
