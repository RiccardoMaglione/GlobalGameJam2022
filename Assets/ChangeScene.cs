using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ChangeScene : StateMachineBehaviour
{ 
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        SceneManager.LoadScene(1);
    }
}
