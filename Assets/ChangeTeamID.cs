using UnityEngine;
public class ChangeTeamID : MonoBehaviour
{
    [SerializeField] CreateNewTeam newTeam;
   public void ChangeID()
    {
        if (!Properties.isRightLetter)
        {
            
            Properties.ActiveTeamID++;
        }
        else
        {
            Properties.isRightLetter = false;
        }
        if(Properties.ActiveTeamID==newTeam.listOfTeams.Count)
        {
            Properties.ActiveTeamID = 0;
        }
    }    
}
