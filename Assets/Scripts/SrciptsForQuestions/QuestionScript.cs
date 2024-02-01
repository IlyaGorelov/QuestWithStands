using TMPro;

using UnityEngine;

public class QuestionScript : MonoBehaviour
{
   public static int activeTeamID = 0;
    bool isQuestionBodyActive = false;
    int questionID;
    [SerializeField] TextMeshProUGUI showTurn;
    [SerializeField] CreateNewTeam createNewTeam;
    TMP_InputField fd;
    GameObject team;
    public GameObject[] questions;
    void Start()
    {
        GameObject team = createNewTeam.listOfTeams[activeTeamID];

    }
    
}
