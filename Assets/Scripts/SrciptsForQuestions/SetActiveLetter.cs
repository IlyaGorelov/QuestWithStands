using UnityEngine;

public class SetActiveLetter : MonoBehaviour
{
    private bool canClick = false;
    [SerializeField] private GameObject cross;

    private void Update()
    {
        if (canClick)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Properties.activeLetter = gameObject.name;
                Debug.Log(Properties.activeLetter);
                cross.SetActive(true);
            }
        }
    }
    private void OnMouseEnter() => canClick = true;

    private void OnMouseExit() => canClick = false;
}
