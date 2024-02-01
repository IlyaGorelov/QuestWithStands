using System;
using System.Collections;
using TMPro;

using UnityEngine;

public class WonderOfU : MonoBehaviour
{
    [SerializeField] AudioSource audioWOU;
    [SerializeField] Animator animWOU;
    [SerializeField] TextMeshProUGUI score;
    [SerializeField] TextMeshProUGUI changeText;
    [SerializeField] AudioSource audioCD;
    [SerializeField] Animator animCD;
     int changeInt;
    public bool doCD = false;
    void Update()
    {
        if (!Properties.isPause && score.text != "0" && Properties.canDoWOU && Convert.ToInt32(score.text)>2000)
        {
            int rand = UnityEngine.Random.Range(0, 10000);
            if (rand == 101)
            {
                animWOU.SetTrigger("WOU");
                audioWOU.Play();
                changeInt = (int)Math.Round(Convert.ToInt32(score.text) * 0.1, 0);
                int temp = (int)Math.Round(Convert.ToInt32(score.text) * 0.9,0);
                score.text = temp.ToString();
                changeText.text = "Минус 10%";
                StartCoroutine(WaitForSeconds(3));
                changeText.text = null;
            }
            Debug.Log(rand);
        }
        if (doCD)
        {
            score.text = (Convert.ToInt32(score.text) + changeInt).ToString();
            audioCD.Play();
            animCD.SetTrigger("CD");
            doCD = false;
        }
    }

    IEnumerator WaitForSeconds(float a)
    {
        yield return new WaitForSecondsRealtime(a);
        changeText.text = null;
    }
}
