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

    }

    public void CountUpSpare()
    {
        CountSpare += 1;
    }
}
