using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Language : MonoBehaviour
{
    public void EngToIta()
    {
        SceneManager.LoadScene("MainMenu_ITA");
    }
    public void ItaToEng()
    {
        SceneManager.LoadScene("MainMenu_ENG");
    }
}