using System;
using UnityEngine;
using UnityEngine.UI;

public class AskQuestions : StateMachineBehaviour
{
    enum Panel { Left, Center, Right, Player };

    [SerializeField] string[] leftQuestions;
    [SerializeField] string[] centerQuestions;
    [SerializeField] string[] rightQuestions;

    string[] tempLeftQuestions;

    GameObject chosenPanel;
    Text panelText;
    GameObject FadeObjectObject;
    ParticleManager particleManager;

    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        FadeObjectObject = GameObject.Find("FadeManager");
        FadeObjectObject.GetComponent<FadeObject>().PanelBlack.SetActive(false);

        particleManager = FindObjectOfType<ParticleManager>();
        animator.SetBool("test", true);
        if (leftQuestions.Length != 0)
        {
            chosenPanel = GameObject.Find("Left");
            panelText = chosenPanel.GetComponentInChildren<Text>();
            chosenPanel.GetComponent<Image>().enabled = true;
            chosenPanel.GetComponent<Button>().enabled = true;
            panelText.enabled = true;
            panelText.text = leftQuestions[0];
            particleManager.particle1.SetActive(true);
        }

        if (centerQuestions.Length != 0)
        {
            chosenPanel = GameObject.Find("Center");
            panelText = chosenPanel.GetComponentInChildren<Text>();
            chosenPanel.GetComponent<Image>().enabled = true;
            chosenPanel.GetComponent<Button>().enabled = true;
            panelText.enabled = true;
            panelText.text = centerQuestions[0];
            particleManager.particle2.SetActive(true);
        }

        if (rightQuestions.Length != 0)
        {
            chosenPanel = GameObject.Find("Right");
            panelText = chosenPanel.GetComponentInChildren<Text>();
            chosenPanel.GetComponent<Image>().enabled = true;
            chosenPanel.GetComponent<Button>().enabled = true;
            panelText.enabled = true;
            panelText.text = rightQuestions[0];
            particleManager.particle3.SetActive(true);
        }
    }

    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {      
        if (animator.GetBool("FirstQuestion") == true)
        {
            if (leftQuestions.Length > 1)
            {
                for (int i = 0; i < leftQuestions.Length - 1; i++)
                {
                    leftQuestions[i] = leftQuestions[i + 1];
                }

                Array.Resize(ref leftQuestions, leftQuestions.Length - 1);
            }

            else
                leftQuestions = new string[leftQuestions.Length - 1];
        }

        if (animator.GetBool("SecondQuestion") == true)
        {
            if (centerQuestions.Length > 1)
            {
                for (int i = 0; i < centerQuestions.Length - 1; i++)
                {
                    centerQuestions[i] = centerQuestions[i + 1];
                }

                Array.Resize(ref centerQuestions, centerQuestions.Length - 1);
            }

            else
                centerQuestions = new string[centerQuestions.Length - 1];
        }

        if (animator.GetBool("ThirdQuestion") == true)
        {
            if (rightQuestions.Length > 1)
            {
                for (int i = 0; i < rightQuestions.Length - 1; i++)
                {
                    rightQuestions[i] = rightQuestions[i + 1];
                }

                Array.Resize(ref rightQuestions, rightQuestions.Length - 1);
            }

            else
                rightQuestions = new string[rightQuestions.Length - 1];
        }

        chosenPanel = GameObject.Find("Left");
        panelText = chosenPanel.GetComponentInChildren<Text>();
        chosenPanel.GetComponent<Image>().enabled = false;
        chosenPanel.GetComponent<Button>().enabled = false;
        panelText.enabled = false;
        particleManager.particle1.SetActive(false);

        chosenPanel = GameObject.Find("Center");
        panelText = chosenPanel.GetComponentInChildren<Text>();
        chosenPanel.GetComponent<Image>().enabled = false;
        chosenPanel.GetComponent<Button>().enabled = false;
        panelText.enabled = false;
        particleManager.particle2.SetActive(false);



        chosenPanel = GameObject.Find("Right");
        panelText = chosenPanel.GetComponentInChildren<Text>();
        chosenPanel.GetComponent<Image>().enabled = false;
        chosenPanel.GetComponent<Button>().enabled = false;
        panelText.enabled = false;
        particleManager.particle3.SetActive(false);


        animator.SetBool("FirstQuestion", false);
        animator.SetBool("SecondQuestion", false);
        animator.SetBool("ThirdQuestion", false);
        animator.SetBool("test", false);
    }
}
