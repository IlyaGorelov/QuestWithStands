using TMPro;
using UnityEngine;

public class QuestionScript : MonoBehaviour
{
    public static int activeTeamID = 0;
    private bool isQuestionBodyActive = false;
    private int questionID;
    [SerializeField] private TextMeshProUGUI showTurn;
    [SerializeField] private CreateNewTeam createNewTeam;
    private TMP_InputField fd;
    private GameObject team;
    public GameObject[] questions;

    private void Start()
    {
        GameObject team = createNewTeam.listOfTeams[activeTeamID];
    }

}
