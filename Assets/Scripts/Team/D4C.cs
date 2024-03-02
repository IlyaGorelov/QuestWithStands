using UnityEngine;

public class D4C : MonoBehaviour
{
    [SerializeField] private GameObject closeArea;
    private GameObject qustions;
    private QuestionScript questionScript;

    private void Start()
    {
        qustions = GameObject.Find("Questions");
        questionScript = qustions.GetComponent<QuestionScript>();
    }

    public void DoD4C()
    {
        Properties.canChange = true;
        closeArea.SetActive(true);
    }
}
