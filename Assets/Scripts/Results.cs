
using System;
using System.Collections;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Video;

public class Results : MonoBehaviour
{
    public CreateNewTeam newTeamScript;
    
    [SerializeField] TextMeshProUGUI Top;
    [SerializeField] GameObject TopImage;
    [SerializeField] VideoPlayer WinSound;
    [SerializeField] GameObject WinVideo;
    int max = 0;
    string NameOfTheFirst;
    int place = 1;
    
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
        WinVideo.SetActive(true);
        TopImage.SetActive(true);
       

        WinSound.Play();
        foreach (var t in newTeamScript.listOfTeams)
        {
            TMP_InputField name = t.GetComponentInChildren<TMP_InputField>();
            TextMeshProUGUI score = t.GetComponentInChildren<TextMeshProUGUI>();

            if (Int32.Parse(score.text) >= max)
            {
                max = Int32.Parse(score.text);
                NameOfTheFirst = name.text;
                Top.text +=place+"   " +NameOfTheFirst + "\n";
                newTeamScript.listOfTeams.Remove(t);
                max = 0;
                place++;
            }
        }
        WinSound.loopPointReached += OnVideoEnd;
    }
    public void newResult()
    {
       


        foreach (var t in newTeamScript.listOfTeams)
        {
            TMP_InputField name = t.GetComponentInChildren<TMP_InputField>();
            TextMeshProUGUI score = t.GetComponentInChildren<TextMeshProUGUI>();

            if (Int32.Parse(score.text) >= max)
            {
                max = Int32.Parse(score.text);
                NameOfTheFirst = name.text;
                Top.text += place + "   " +NameOfTheFirst + "\n";
                newTeamScript.listOfTeams.Remove(t);
                max = 0;
                place++;
            }
        }

    }
   
    void OnVideoEnd(UnityEngine.Video.VideoPlayer videoPlayer)
    {
        WinVideo.SetActive(false);
    }
     public void SkipVideo()
    {
        WinVideo.SetActive(false);
    }

    
}
