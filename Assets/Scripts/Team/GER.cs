using TMPro;
using UnityEngine;

public class GER : MonoBehaviour
{
    [SerializeField] private GameObject closeArea;
    [SerializeField] private TMP_InputField numOfTeam;
    private CreateNewTeam newTeam;

    private void Start()
    {
        GameObject teams = GameObject.Find("Teams");
        newTeam = teams.GetComponent<CreateNewTeam>();
    }

    public void DoGER()
    {
        int num = int.Parse(numOfTeam.text) - 1;
        Debug.Log(num);
        newTeam.listOfTeams[num].GetComponentInChildren<Destroy>().isGER = true;
        closeArea.SetActive(true);
        Properties.doGER = true;
        newTeam.listOfTeams.Remove(newTeam.listOfTeams[num]);
    }
}
