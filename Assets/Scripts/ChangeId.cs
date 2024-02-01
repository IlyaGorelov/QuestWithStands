
using UnityEngine;

public class ChangeId : MonoBehaviour
{
    [SerializeField] ThisQuestion question;
    public void changeID()
    {
        Properties.QuestID = question.questID;
    }
}
