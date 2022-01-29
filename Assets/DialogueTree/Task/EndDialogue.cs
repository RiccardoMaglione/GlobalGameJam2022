using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class EndDialogue : StateMachineBehaviour
{
    [SerializeField] string sentence;

    CharactersManager characterManager;
    ButtonManager buttonManager;
    
    Text panelText;
    GameObject chosenPanel;
    
    GameObject letItOut;
    GameObject condemn;

    Text letItOutButtonText;
    Text condemnButtonText;


    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        letItOut = GameObject.Find("LetItOut");
        condemn = GameObject.Find("Condemn");
        chosenPanel = GameObject.Find("Center");

        panelText = chosenPanel.GetComponentInChildren<Text>();
        letItOutButtonText = letItOut.GetComponentInChildren<Text>();
        condemnButtonText = letItOut.GetComponentInChildren<Text>();

        letItOut.GetComponent<Image>().enabled = true;
        condemn.GetComponent<Image>().enabled = true;
        chosenPanel.GetComponent<Image>().enabled = true;

        letItOut.GetComponent<Button>().enabled = true;
        condemn.GetComponent<Button>().enabled = true;

        panelText.enabled = true;
        letItOutButtonText.enabled = true;
        condemnButtonText.enabled = true;

        panelText.text = sentence;      
    }

    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.SetBool("Condemn", false);
        animator.SetBool("LetItOut", false);

        letItOut.GetComponent<Image>().enabled = false;
        condemn.GetComponent<Image>().enabled = false;
        chosenPanel.GetComponent<Image>().enabled = false;

        letItOut.GetComponent<Button>().enabled = false;
        condemn.GetComponent<Button>().enabled = false;

        panelText.enabled = false;
        letItOutButtonText.enabled = false;
        condemnButtonText.enabled = false;

        //characterManager = FindObjectOfType<CharactersManager>();
        //buttonManager = FindObjectOfType<ButtonManager>();
        //buttonManager.i++;
        //characterManager.PlayDialogue();
    }
}
