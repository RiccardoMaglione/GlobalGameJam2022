using UnityEngine;
using UnityEngine.UI;

public class DisplayLine : StateMachineBehaviour
{
    enum Panel {First, Second, Third};
    
    [SerializeField] string sentence; 
    [SerializeField] Panel panelPosition;

    GameObject chosenPanel;
    Text panelText;
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {  
        
        chosenPanel = GameObject.Find(panelPosition.ToString());
        panelText = chosenPanel.GetComponentInChildren<Text>();
        chosenPanel.GetComponent<Image>().enabled = true;
        panelText.enabled = true;
        panelText.text = sentence;
    }

    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        chosenPanel.GetComponent<Image>().enabled = false;
        panelText.enabled = false;
        animator.SetBool("NextLine", false);
    }
}
