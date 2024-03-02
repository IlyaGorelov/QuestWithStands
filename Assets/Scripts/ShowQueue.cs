using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ShowQueue : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI queueText;
    [SerializeField] private GameObject queueObject;
    [SerializeField] private List<string> names;
    private GameObject team;
    [SerializeField] private CreateNewTeam createNewTeam;
    private void Start()
    {
        queueObject.SetActive(false);
    }

    public void Show()
    {
        string name;
        foreach (var item in createNewTeam.listOfTeams)
        {
            name = item.GetComponentInChildren<TMP_InputField>().text;
            names.Add(name);
        }
        queueObject.SetActive(true);
        queueText.text = "Очередь команды " + names[Properties.ActiveTeamID];
        StartCoroutine(showText());
    }

    IEnumerator showText()
    {
        yield return new WaitForSeconds(1);
        queueObject.SetActive(false);
    }
}
