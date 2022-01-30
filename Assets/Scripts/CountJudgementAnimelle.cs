using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CountJudgementAnimelle : MonoBehaviour
{
    public int CountSpare;
    public string NameGameover12;
    public string NameGameover34;
    public string NameGameover56;

    void Update()
    {
        if (CountSpare == 1 || CountSpare == 2)
        {
            SceneManager.LoadScene(NameGameover12);
        }
        if (CountSpare == 3 || CountSpare == 4)
        {
            SceneManager.LoadScene(NameGameover34);
        }
        if (CountSpare == 5 || CountSpare == 6)
        {
            SceneManager.LoadScene(NameGameover56);
        }
    }

    public void CountUpSpare()
    {
        CountSpare += 1;
    }
}
