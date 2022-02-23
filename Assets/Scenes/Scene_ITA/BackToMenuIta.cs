using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMenuIta : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(GoToMenuITA());
    }

    public IEnumerator GoToMenuITA()
    {
        yield return new WaitForSeconds(19);
        {
            SceneManager.LoadScene("MainMenu_ITA");
        }
    }
}
