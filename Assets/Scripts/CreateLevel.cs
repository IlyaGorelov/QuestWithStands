
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreateLevel : MonoBehaviour
{
    [SerializeField] private GameObject loadImage;
    public void Create()
    {
        loadImage.SetActive(true);
        StartCoroutine(Load());
    }

    IEnumerator Load()
    {
        AsyncOperation loadAsync = SceneManager.LoadSceneAsync(1);
        yield return null;
    }
}
