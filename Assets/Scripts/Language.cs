using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Language : MonoBehaviour
{
    public GameObject MenuPanel;
    public GameObject OptionPanel;

    public static bool isSceneIta;
    public static bool isSceneEng;
    private void Start()
    {
        if (isSceneEng)
        {
            print("eng");
            MenuPanel.SetActive(false);
            OptionPanel.SetActive(true);
        }
        if (isSceneIta)
        {
            print("ita");
            MenuPanel.SetActive(false);
            OptionPanel.SetActive(true);
        }

    }


    public void EngToIta()
    {
        isSceneIta = true;
        isSceneEng = false;
        SceneManager.LoadScene("MainMenu_ITA");
    }
    public void ItaToEng()
    {
        isSceneIta = false;
        isSceneEng = true;
        SceneManager.LoadScene("MainMenu_ENG");
    }
}