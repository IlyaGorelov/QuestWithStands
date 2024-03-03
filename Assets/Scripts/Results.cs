using System;
using TMPro;
using UnityEngine;
using UnityEngine.Video;

public class Results : MonoBehaviour
{
    public CreateNewTeam newTeamScript;
    [SerializeField] private TextMeshProUGUI Top;
    [SerializeField] private GameObject TopImage;
    [SerializeField] private AudioSource Music;
    private VideoClip a;
    private int max = 0;
    private string NameOfTheFirst;
    private int place = 1;

    private void Update()
    {
        foreach (var t in newTeamScript.listOfTeams)
        {
            TMP_InputField name = t.GetComponentInChildren<TMP_InputField>();
            TextMeshProUGUI score = t.GetComponentInChildren<TextMeshProUGUI>();
            if (Int32.Parse(score.text) >= max)
            {
                max = Int32.Parse(score.text);
                NameOfTheFirst = name.text;
            }
        }
    }

    public void GetResults()
    {
        Music.Play();
        TopImage.SetActive(true);
        foreach (var t in newTeamScript.listOfTeams)
        {
            TMP_InputField name = t.GetComponentInChildren<TMP_InputField>();
            TextMeshProUGUI score = t.GetComponentInChildren<TextMeshProUGUI>();
            if (Int32.Parse(score.text) >= max)
            {
                max = Int32.Parse(score.text);
                NameOfTheFirst = name.text;
                Top.text += place + "   " + NameOfTheFirst + "\n";
                newTeamScript.listOfTeams.Remove(t);
                max = 0;
                place++;
            }
        }
    }
    public void NewResult()
    {
        foreach (var t in newTeamScript.listOfTeams)
        {
            TMP_InputField name = t.GetComponentInChildren<TMP_InputField>();
            TextMeshProUGUI score = t.GetComponentInChildren<TextMeshProUGUI>();

            if (Int32.Parse(score.text) >= max)
            {
                max = Int32.Parse(score.text);
                NameOfTheFirst = name.text;
                Top.text += place + "   " + NameOfTheFirst + "\n";
                newTeamScript.listOfTeams.Remove(t);
                max = 0;
                place++;
            }
        }
    }

    public void Skip() => Music.Pause();
}
