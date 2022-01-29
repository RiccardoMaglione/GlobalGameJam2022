using UnityEngine;
using UnityEngine.InputSystem;

public class InputController : MonoBehaviour
{
    InputManager inputManager;

    [SerializeField] Animator[] dialogues;
    [HideInInspector] public int i = 0;

    void Awake()
    {
        inputManager = new InputManager();
    }

    void OnEnable()
    {
        inputManager.Player.NextLine.performed += DisplayNextLine;
        inputManager.Player.NextLine.Enable();
    }

    void OnDisable()
    {
        inputManager.Player.NextLine.performed -= DisplayNextLine;
        inputManager.Player.NextLine.Disable();
    }

    void DisplayNextLine(InputAction.CallbackContext obj)
    {
        dialogues[i].SetBool("NextLine", true);
    }
}
