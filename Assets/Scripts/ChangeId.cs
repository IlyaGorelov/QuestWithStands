using UnityEngine;

public class ChangeId : MonoBehaviour
{
    [SerializeField] private ThisQuestion question;

    public void �hangeID()
    {
        Properties.QuestID = question.questID;
    }
}
