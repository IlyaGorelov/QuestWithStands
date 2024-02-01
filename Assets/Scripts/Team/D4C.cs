
using UnityEngine;

public class D4C : MonoBehaviour
{
    [SerializeField] private GameObject closeArea;
    GameObject qustions;
    QuestionScript questionScript;
    private void Start()
    {
        qustions = GameObject.Find("Questions");
        questionScript= qustions.GetComponent<QuestionScript>();
    }
    public void DoD4C()
    {
        //foreach (var item in questionScript.questions)
        //{
            Properties.canChange = true;
        //    ThisQuestion thisQuestion = item.GetComponent<ThisQuestion>();
        //    if (thisQuestion.questID ==Properties.QuestID) 
        //    {
        //        ChangeText changeText=item.GetComponentInChildren<ChangeText>();
        //        changeText.canChange = true;

        //    }
        //}
        closeArea.SetActive(true);
    }
}
