using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.Video;

public class ClockTicking : MonoBehaviour
{
    [SerializeField] private int time = 30;
    public VideoPlayer[] _player;
    public TextMeshProUGUI timeText;
    public Animation _tempTextAnim;
    public TextMeshProUGUI _tempText;
    [Header("Audio")]
    public AudioSource[] clockTicking;
    public AudioSource kingCrimsonSound;

    [Header("Animator")]
    [SerializeField] private Animator TheWorld;
    [SerializeField] private Animator KingCrimson;

    private int randomValue;

    private bool IsStart = false;
    private IEnumerator cor;
    private ClockSound clock;

    private void Start()
    {
        cor = Rotatr();
        randomValue = Random.Range(0, 8);
        clock = FindObjectOfType<ClockSound>();
        clockTicking = clock.audios;
    }

    private void OnDisable()
    {
        foreach (var c in clockTicking)
        {
            c.Stop();
        }
    }
    public void StartTime()
    {
        if (!IsStart)
        {
            IsStart = true;
            StartCoroutine(cor);
            foreach (var tic in clockTicking)
            {
                tic.volume = 1;
            }
        }
        else
        {
            IsStart = false;
            StopCoroutine(cor);
            foreach (var tic in clockTicking)
            {
                tic.volume = 0;
            }
        }
    }

    IEnumerator Rotatr()
    {
        int RandomMelody = Random.Range(0, clockTicking.Length);
        int randomForChoice = Random.Range(0, 6);
        if (randomForChoice < 3)
        {
            RandomMelody = 0;
            Debug.Log(clockTicking[RandomMelody]);
        }
        if (randomValue == 0)
        {
            clockTicking[RandomMelody].Play();
            while (time >= 0 || !IsStart)
            {
                Debug.Log("start Timer1");
                yield return new WaitForSeconds(1);
                timeText.text = time.ToString();
                time--;
                if (time == 9)
                {
                    clockTicking[RandomMelody].Pause();
                    _tempText.text = "+ 10 секунд";
                    _tempTextAnim.Play();
                    _player[0].Play();
                    yield return new WaitForSeconds(1.5f);
                    TheWorld.SetTrigger("Appear");
                    yield return new WaitForSeconds(15);
                    clockTicking[RandomMelody].Play();
                }
            }
            clockTicking[RandomMelody].Stop();
        }
        if (randomValue == 1)
        {
            clockTicking[RandomMelody].Play();
            while (time >= 0 || !IsStart)
            {
                Debug.Log("start Timer2");
                yield return new WaitForSeconds(1);
                timeText.text = time.ToString();
                time--;
                if (time == 9)
                {
                    kingCrimsonSound.Play();
                    clockTicking[RandomMelody].Pause();
                    yield return new WaitForSeconds(2);
                    _tempText.text = "- 10 секунд";
                    _tempTextAnim.Play();
                    KingCrimson.SetTrigger("Appear");
                    _player[randomValue].Play();
                    time -= 9;
                    timeText.text = "0";
                }
            }
            clockTicking[RandomMelody].Stop();
        }
        if (randomValue >= 2)
        {
            clockTicking[RandomMelody].Play();
            while (time >= 0 || !IsStart)
            {
                Debug.Log("start Timer3");
                yield return new WaitForSeconds(1);
                timeText.text = time.ToString();
                time--;
            }
            clockTicking[RandomMelody].Stop();
        }
    }
}
