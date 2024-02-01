
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreateLevel : MonoBehaviour
{
    [SerializeField] GameObject loadImage;
    public void Create()
    {
        loadImage.SetActive(true);
        StartCoroutine(load());
    }

    IEnumerator load()
    {
        AsyncOperation loadAsync = SceneManager.LoadSceneAsync(1);
        yield return null;
    }
}
