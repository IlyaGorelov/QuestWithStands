using System;
using System.Collections;
using TMPro;
using UnityEngine;

public class WonderOfU : MonoBehaviour
{
    [SerializeField] private AudioSource audioWOU;
    [SerializeField] private Animator animWOU;
    [SerializeField] private TextMeshProUGUI score;
    [SerializeField] private TextMeshProUGUI changeText;
    [SerializeField] private AudioSource audioCD;
    [SerializeField] private Animator animCD;
    private int changeInt;
    public bool doCD = false;

    private void Update()
    {
        if (!Properties.isPause && score.text != "0" && Properties.canDoWOU && Convert.ToInt32(score.text) > 2000 && !Properties.LockWouForever)
        {
            int rand = UnityEngine.Random.Range(0, Properties.maxWOU);
            if (rand == 101)
            {
                animWOU.SetTrigger("WOU");
                audioWOU.Play();
                changeInt = (int)Math.Round(Convert.ToInt32(score.text) * 0.1, 0);
                int temp = (int)Math.Round(Convert.ToInt32(score.text) * 0.9, 0);
                score.text = temp.ToString();
                changeText.text = "Минус 10%";
                StartCoroutine(WaitForSeconds(3));
                changeText.text = null;
                StartCoroutine(StopStands());
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
    IEnumerator StopStands()
    {
        Properties.canDoD4C = false;
        Properties.canDoWOU = false;
        yield return new WaitForSecondsRealtime(10);
        Properties.canDoD4C = true;
        Properties.canDoWOU = true;
    }
}
