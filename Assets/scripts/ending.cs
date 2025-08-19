using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ending : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        StartCoroutine(EndingScene());
    }

    private IEnumerator EndingScene()
    {
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene("menu");
    }
}
