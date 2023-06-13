using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PressRetry : MonoBehaviour
{
    public void LoadScenes(string cena2)
    {
        SceneManager.LoadScene(cena2);
    }
}
