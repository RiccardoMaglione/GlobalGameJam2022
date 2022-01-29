using UnityEngine;
using UnityEngine.UI;

public class AskQuestions : StateMachineBehaviour
{
    enum Panel { Left, Center, Right, Player };

    [SerializeField] string[] question;
    [SerializeField] Panel[] panelPosition;

    GameObject chosenPanel;
    Text panelText;

    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        for (int i = 0; i < question.Length; i++)
        {
            chosenPanel = GameObject.Find(panelPosition[i].ToString());
            panelText = chosenPanel.GetComponentInChildren<Text>();
            chosenPanel.GetComponent<Image>().enabled = true;
            chosenPanel.GetComponent<Button>().enabled = true;
            panelText.enabled = true;
            panelText.text = question[i];
        }      
    }

    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        for (int i = 0; i < question.Length; i++)
        {
            chosenPanel = GameObject.Find(panelPosition[i].ToString());
            panelText = chosenPanel.GetComponentInChildren<Text>();
            chosenPanel.GetComponent<Image>().enabled = false;
            chosenPanel.GetComponent<Button>().enabled = false;
            panelText.enabled = false;
        }

        animator.SetBool("FirstQuestion", false);
        animator.SetBool("SecondQuestion", false);
        animator.SetBool("ThirdQuestion", false);
    }
}
