using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class gameOverScreen : MonoBehaviour
{
   public void restart()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("level1mp");
    }

    public void quit()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("menu");
    }
}
