
using UnityEngine;
using UnityEngine.SceneManagement;

public class Quit : MonoBehaviour
{
   public void Exit()
    {
        SceneManager.LoadScene(0);
    }
}
