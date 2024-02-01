using System;
using TMPro;
using UnityEngine;
public class BuyStand : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI score;
    [SerializeField] TextMeshProUGUI price;
    [SerializeField] GameObject closeArea;
    public void Pay()
    {
        int _score=Convert.ToInt32(score.text);
        int _price=Convert.ToInt32(price.text);
        _score -= _price;
        score.text = _score.ToString();
        closeArea.SetActive(false);
    }
}
