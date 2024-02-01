
using System.Collections;
using UnityEngine;

public class rollTheDrum : MonoBehaviour
{
    [SerializeField] GameObject drum;
    [SerializeField] float smooth=0;
    [SerializeField] AudioSource audio;
    public void Roll()
    {
        audio.Play();
        Properties.isEndOfRoll=false;
        int rand = Random.Range(1, 3);
        StartCoroutine(WaitForSeconds(rand));
    }
    private void Update()
    {
       drum.transform.rotation *= Quaternion.Euler(0, 0, smooth);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            smooth = 0;
        }
    }

    IEnumerator WaitForSeconds(int t)
    {
        smooth = 1;
        yield return new WaitForSeconds(t);
        for (int i = 0; i < 10; i++)
        {
            yield return new WaitForSeconds(0.2f);
            smooth -=0.1f;
        }
       Properties.isEndOfRoll = true;
        audio.Stop();
        smooth = 0;
    }


}
