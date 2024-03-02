using TMPro;
using UnityEngine;

public class FieldOfWondersOnTeam : MonoBehaviour
{
    public int tempScore = 0;
    [SerializeField] private TextMeshProUGUI text;

    private void Update()
    {
        if (tempScore != 0)
        {
            text.text = tempScore.ToString();
        }
        else
        {
            text.text = "";
        }
    }
}
