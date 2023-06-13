using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PressMenu : MonoBehaviour
{
    public void LoadScenes(string cena4)
    {
        SceneManager.LoadScene(cena4);
    }
}
