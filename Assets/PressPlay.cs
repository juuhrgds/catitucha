using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PressPlay : MonoBehaviour
{
    public void LoadScenes(string cena)
    {
        SceneManager.LoadScene(cena);
    }
}
