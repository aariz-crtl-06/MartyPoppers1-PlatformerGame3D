using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class introTiming : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        StartCoroutine(IntroScene());
    }

    private IEnumerator IntroScene()
    {
        yield return new WaitForSeconds(23f);
        SceneManager.LoadScene("level1mp");
    }
}
