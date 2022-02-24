using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMenu : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(GoToMenuENG());
    }

    public IEnumerator GoToMenuENG()
    {
        yield return new WaitForSeconds(19);
        {
            SceneManager.LoadScene("MainMenu_ENG");
        }
    }
}
