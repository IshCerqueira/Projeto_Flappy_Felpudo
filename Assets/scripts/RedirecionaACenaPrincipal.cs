using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RedirecionaACenaPrincipal : MonoBehaviour
{
 

    public void OnStartClick()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void OnStartClick2()
    {
        SceneManager.LoadScene("Menu");
    }

    public void OnStartClick3()
    {
        SceneManager.LoadScene("WinScene");
    }
}
