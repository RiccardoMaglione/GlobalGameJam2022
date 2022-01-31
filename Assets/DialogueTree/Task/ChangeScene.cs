using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ChangeScene : StateMachineBehaviour
{
    GameObject CountJudge;

    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

        CountJudge = GameObject.Find("CountJudgmenet");

        if (CountJudge.GetComponent<CountJudgementAnimelle>().CountSpared == 0 || CountJudge.GetComponent<CountJudgementAnimelle>().CountSpared == 1 || CountJudge.GetComponent<CountJudgementAnimelle>().CountSpared == 2)
        {
            SceneManager.LoadScene(CountJudge.GetComponent<CountJudgementAnimelle>().NameGameover12);
        }
        if (CountJudge.GetComponent<CountJudgementAnimelle>().CountSpared == 3 || CountJudge.GetComponent<CountJudgementAnimelle>().CountSpared == 4)
        {
            SceneManager.LoadScene(CountJudge.GetComponent<CountJudgementAnimelle>().NameGameover34);
        }
        if (CountJudge.GetComponent<CountJudgementAnimelle>().CountSpared == 5 || CountJudge.GetComponent<CountJudgementAnimelle>().CountSpared == 6)
        {
            SceneManager.LoadScene(CountJudge.GetComponent<CountJudgementAnimelle>().NameGameover56);
        }


        //SceneManager.LoadScene(1);
    }
}
