using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CountJudgementAnimelle : MonoBehaviour
{
    public int CountSpared;
    public string NameGameover12;
    public string NameGameover34;
    public string NameGameover56;

    public void CountUpSpared()
    {
        CountSpared += 1;
    }
}
