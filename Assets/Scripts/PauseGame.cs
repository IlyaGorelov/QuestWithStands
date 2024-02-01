
using UnityEngine;

public class PauseGame : MonoBehaviour
{
    [SerializeField] GameObject pauseImage;
     void Update()
    {
        if (!Properties.isPause&&Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("pause");
            Properties.isPause = true;
            pauseImage.SetActive(true);
        }
       else if (Properties.isPause&& Input.GetKeyDown(KeyCode.Escape))
        {
            Properties.isPause = false;
            pauseImage.SetActive(false);
        }
    }
}
