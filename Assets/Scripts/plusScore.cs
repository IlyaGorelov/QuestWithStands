using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class plusScore : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI score;
    [SerializeField] TMP_InputField Changescore;
    [SerializeField] GameObject ChangeImage;

    public void Plus()
    {
        int old=Int32.Parse(score.text);
        int newScore= old + Int32.Parse(Changescore.text);
        score.text=newScore.ToString();
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
