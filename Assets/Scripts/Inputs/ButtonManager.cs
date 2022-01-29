using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    CharactersManager charactersManager;
    Animator[] anim;
    [HideInInspector] public int i = 0;
    GameObject judgementManager;
    void Awake()
    {
        
        charactersManager = FindObjectOfType<CharactersManager>();
        anim = new Animator[charactersManager.characters.Length];
        for (int i = 0; i < charactersManager.characters.Length; i++)
        {
            anim[i] = charactersManager.characters[i].GetComponentInChildren<Animator>();
        }

        judgementManager = GameObject.Find("JudgementManager");
    }


    public void FirstButton()
    {
        anim[i].SetBool("FirstQuestion", true);
        if (anim[i].GetBool("b1") == true)
            anim[i].SetBool("b2", true);
        else
            anim[i].SetBool("b1", true);
    }

    public void SecondButton()
    {
        anim[i].SetBool("SecondQuestion", true);
        if (anim[i].GetBool("n1") == true)
            anim[i].SetBool("n2", true);
        else
            anim[i].SetBool("n1", true);
    }

    public void ThirdButton()
    {
        anim[i].SetBool("ThirdQuestion", true);
        if (anim[i].GetBool("c1") == true)
            anim[i].SetBool("c2", true);
        else
            anim[i].SetBool("c1", true);
    }

    public void LetItOutButton()
    {
        anim[i].SetBool("LetItOut", true);
        print("salvo");
        judgementManager.GetComponent<JudgementPanel>().DeactivePanelLetItOut();
    }

    public void CondemnButton()
    {
        anim[i].SetBool("Condemn", true);
        print("condannato");
        judgementManager.GetComponent<JudgementPanel>().DeactivePanelCondamn();
    }
}
