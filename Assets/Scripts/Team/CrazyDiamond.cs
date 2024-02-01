using TMPro;
using UnityEngine;
public class CrazyDiamond : MonoBehaviour
{
    [SerializeField] GameObject closeArea;
    [SerializeField] TMP_InputField numOfTeam;
    CreateNewTeam newTeam;
    private void Start()
    {

        GameObject teams = GameObject.Find("Teams");
        newTeam = teams.GetComponent<CreateNewTeam>();
    }
    public void DoT4()
    {
        int num = int.Parse(numOfTeam.text)-1;
        Debug.Log(num);
        newTeam.listOfTeams[num].GetComponentInChildren<WonderOfU>().doCD = true;
        closeArea.SetActive(true);
    }
}
