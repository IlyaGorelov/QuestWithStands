using System;
using TMPro;
using UnityEngine;

public class AddPoints : MonoBehaviour
{
    private CreateNewTeam team;
    private FieldOfWondersOnTeam field;
    [SerializeField] private TextMeshProUGUI points;
    private bool canAdd = true;

    private void Start()
    {
        team = GetComponentInParent<CreateNewTeam>();
        field = GetComponent<FieldOfWondersOnTeam>();
    }

    void Update()
    {
        if (Properties.ActiveTeamID == team.listOfTeams.IndexOf(gameObject) && Properties.canAdd)
        {
            Properties.canAdd = false;
            points.text = (Convert.ToInt32(points.text) + Properties.QuestID * 100).ToString();
        }
        else if (Properties.ActiveTeamID == team.listOfTeams.IndexOf(gameObject) && Properties.canAddToField && Properties.isFieldOfWonders)
        {
            Properties.canAddToField = false;
            switch (Properties.activeField)
            {
                case "100":
                case "150":
                case "500":
                case "350":
                case "250":
                case "400":
                case "50":
                case "0":
                case "300":
                case "200":
                case "450":
                    field.tempScore += Int32.Parse(Properties.activeField);
                    break;
                case "x2":
                    field.tempScore *= 2;
                    break;
            }
        }
        else if (Properties.ActiveTeamID == team.listOfTeams.IndexOf(gameObject))
        {
            if (Properties.activeField == "B" && Properties.isEndOfRoll)
            {
                field.tempScore = 0;
            }
        }
        if (Properties.isFieldEnd && canAdd)
        {
            canAdd = false;
            points.text = (field.tempScore + Int32.Parse(points.text)).ToString();
            field.tempScore = 0;
        }
        if (!Properties.isFieldEnd)
        {
            canAdd = true;
        }
    }
}