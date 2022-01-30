using UnityEngine;
using UnityEngine.UI;

public class DisplayLine : StateMachineBehaviour
{
    enum Panel { Left, Center, Right, Player };

    [SerializeField] string sentence;
    [SerializeField] Panel panelPosition;

    GameObject chosenPanel;
    Text panelText;
    GameObject fiot;

    CharactersManager characterManager;
    ButtonManager buttonManager;

    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        fiot = GameObject.Find("FadeManager");
        chosenPanel = GameObject.Find(panelPosition.ToString());
        panelText = chosenPanel.GetComponentInChildren<Text>();
        chosenPanel.GetComponent<Image>().enabled = true;
        panelText.enabled = true;
        panelText.text = sentence;

        //if (animator.GetCurrentAnimatorStateInfo(0).IsName("fade"))
        //{
        //    fiot.GetComponent<FadeObject>().PanelBlack.SetActive(true);
        //    fiot.GetComponent<FadeObject>().FadeImage(fiot.GetComponent<FadeObject>().PanelBlack);
        //}
    }

    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        chosenPanel.GetComponent<Image>().enabled = false;
        panelText.enabled = false;
        animator.SetBool("NextLine", false);
    }
}