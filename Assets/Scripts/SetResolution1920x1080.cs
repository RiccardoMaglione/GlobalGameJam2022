using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetResolution1920x1080 : MonoBehaviour
{
    #if UNITY_STANDALONE
    private void Awake()
    {
        Screen.SetResolution(1920, 1080, true);
    }
    #endif

    #if UNITY_ANDROID
    private void Awake()
    {
        Screen.SetResolution(1280, 720, true);
    }
    #endif
}
