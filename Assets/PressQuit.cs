using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PressQuit : MonoBehaviour
{
    public void LoadScenes(string cena3)
    {
        SceneManager.LoadScene(cena3);
    }
}
