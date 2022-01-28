using UnityEngine;
using UnityEngine.InputSystem;

public class InputController : MonoBehaviour
{
    InputManager inputManager;

    Animator anim;

    void Awake()
    {
        inputManager = new InputManager();
        anim = FindObjectOfType<Animator>();
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
        anim.SetBool("NextLine", true);
    }
}
