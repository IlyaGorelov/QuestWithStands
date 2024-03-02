using UnityEngine;

public class ChangeId : MonoBehaviour
{
    [SerializeField] private ThisQuestion question;

    public void ÑhangeID()
    {
        Properties.QuestID = question.questID;
    }
}
