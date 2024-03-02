using TMPro;
using UnityEngine;

public class changeQueueTextColor : MonoBehaviour
{
    private TextMeshProUGUI text;

    private void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        if (Properties.isFieldOfWonders)
        {
            text.color = Color.black;
        }
        else
        {
            text.color = Color.white;
        }
    }
}
