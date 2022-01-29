using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    CharactersManager charactersManager;
    Animator[] anim;
    [HideInInspector] public int i = 0;

    void Awake()
    {
        
        charactersManager = FindObjectOfType<CharactersManager>();
        anim = new Animator[charactersManager.characters.Length];
        for (int i = 0; i < charactersManager.characters.Length; i++)
        {
            anim[i] = charactersManager.characters[i].GetComponentInChildren<Animator>();
        }
    }


    public void FirstButton()
    {
        anim[i].SetBool("FirstQuestion", true);
    }

    public void SecondButton()
    {
        anim[i].SetBool("SecondQuestion", true);
    }

    public void ThirdButton()
    {
        anim[i].SetBool("ThirdQuestion", true);
    }
}
