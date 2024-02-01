
using UnityEngine;

public class changeThisTeam : MonoBehaviour
{
    public bool Can;
    public static bool ChooseAll;
    SpriteRenderer spriteRenderer;
    private void Start()
    {
        spriteRenderer=GetComponent<SpriteRenderer>();
    }
    private void Update()
    {
        if (Can||ChooseAll)
        {
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.position -= transform.right * (0.1f/4);
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.position += transform.right * (0.1f / 4);
            }
            if (Input.GetKey(KeyCode.UpArrow))
            {
                transform.localScale += transform.localScale * (0.1f / 4);
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                transform.localScale -= transform.localScale * (0.1f / 4);
            }
            if (Input.GetKey(KeyCode.LeftShift))
            {
                Vector2 screenPosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
                Vector2 worldPosition = Camera.main.ScreenToWorldPoint(screenPosition);
                transform.position = worldPosition;
            }
        }
    }
    public void CanChange()
    {
        
        if (Can) Can = false;
        else Can = true;
    }
    public void ChooseAl()
    {

        if (ChooseAll) ChooseAll = false;
        else ChooseAll = true;
    }

    
}
