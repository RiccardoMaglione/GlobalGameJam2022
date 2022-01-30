using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ChangeScene : StateMachineBehaviour
{
    GameObject CountJudge;

    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

        CountJudge = GameObject.Find("CountJudgmenet");

        if (CountJudge.GetComponent<CountJudgementAnimelle>().CountSpare == 1 || CountJudge.GetComponent<CountJudgementAnimelle>().CountSpare == 2)
        {
            SceneManager.LoadScene(CountJudge.GetComponent<CountJudgementAnimelle>().NameGameover56);
        }
        if (CountJudge.GetComponent<CountJudgementAnimelle>().CountSpare == 3 || CountJudge.GetComponent<CountJudgementAnimelle>().CountSpare == 4)
        {
            SceneManager.LoadScene(CountJudge.GetComponent<CountJudgementAnimelle>().NameGameover34);
        }
        if (CountJudge.GetComponent<CountJudgementAnimelle>().CountSpare == 5 || CountJudge.GetComponent<CountJudgementAnimelle>().CountSpare == 6)
        {
            SceneManager.LoadScene(CountJudge.GetComponent<CountJudgementAnimelle>().NameGameover12);
        }


        //SceneManager.LoadScene(1);
    }
}
