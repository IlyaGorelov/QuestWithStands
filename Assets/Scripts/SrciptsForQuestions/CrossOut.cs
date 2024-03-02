using System.Collections.Generic;
using UnityEngine;

public class CrossOut : MonoBehaviour
{
    [SerializeField] private GameObject cross;
    private Transform target;
    private GameObject tCross;
    private bool canDo = false;
    [SerializeField] private List<GameObject> crosses;

    private void Start() => target = GetComponent<Transform>();

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && canDo)
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            tCross = Instantiate(cross, mousePos, Quaternion.identity);
            tCross.transform.SetParent(transform);
            tCross.transform.localScale = new Vector3(0.54922f, 0.411915f, 0.54922f);
            tCross.transform.position = new Vector3(tCross.transform.position.x, tCross.transform.position.y, 0);
            crosses.Add(tCross);
        }
        if (Input.GetKey(KeyCode.LeftControl) && Input.GetKeyDown(KeyCode.Z))
        {
            Destroy(crosses[crosses.Count - 1]);
            crosses.Remove(crosses[crosses.Count - 1]);
        }
    }

    private void OnMouseEnter() => canDo = true;

    private void OnMouseExit() => canDo = false;
}
