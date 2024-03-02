using TMPro;
using UnityEngine;

public class Tusk4 : MonoBehaviour
{
    [SerializeField] private GameObject closeArea;
    [SerializeField] private TMP_InputField numOfTeam;
    private CreateNewTeam newTeam;

    private void Start()
    {

        GameObject teams = GameObject.Find("Teams");
        newTeam = teams.GetComponent<CreateNewTeam>();
    }

    public void DoT4()
    {
        int num = int.Parse(numOfTeam.text) - 1;
        Debug.Log(num);
        newTeam.listOfTeams[num].GetComponentInChildren<D4CLoveTrain>().doT4 = true;
        closeArea.SetActive(true);
    }
}
