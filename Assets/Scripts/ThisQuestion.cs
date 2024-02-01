
using System;
using TMPro;
using UnityEngine;

public class ThisQuestion : MonoBehaviour
{
    public int questID;
    [SerializeField] QuestionScript questionScript;
    
    public void activateQuest()
    {
        Properties.canAdd = true;
    }

    public void SetActiveQuestID()
    {
        Properties.QuestID = questID;
    }

}
