using System;
using System.Collections;
using TMPro;
using UnityEngine;

public class D4CLoveTrain : MonoBehaviour
{
    [SerializeField] AudioSource audioD4C;
    [SerializeField] Animator animD4c;
    [SerializeField] AudioSource audioT4;
    [SerializeField] Animator animT4;
    [SerializeField] TextMeshProUGUI score;
    [SerializeField] TextMeshProUGUI changeText;
    int changeInt;
    public bool doT4;
    void Update()
    {
        if (!Properties.isPause && score.text != "0" && Properties.canDoD4C && Convert.ToInt32(score.text) > 2000)
        {
            int rand = UnityEngine.Random.Range(0, 10000);
            if (rand == 1)
            {
                animD4c.SetTrigger("D4C");
                audioD4C.Play();
                changeInt = (int)Math.Round(Convert.ToInt32(score.text) * 0.1, 0);
                int temp = (int)Math.Round(Convert.ToInt32(score.text) * 1.1, 0);
                score.text = temp.ToString();
                changeText.text = "Плюс 10%";
                StartCoroutine(WaitForSeconds(3));
                changeText.text = null;
            }
            Debug.Log(rand);
        }
        if (doT4)
        {
            score.text = (Convert.ToInt32(score.text)-changeInt).ToString();
            audioT4.Play();
            animT4.SetTrigger("T4");
            doT4 = false;
        }
    }
    IEnumerator WaitForSeconds(float a)
    {
        yield return new WaitForSecondsRealtime(a);
        changeText.text = null;
    }
}