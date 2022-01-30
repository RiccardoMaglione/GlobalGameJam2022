using UnityEngine;
using UnityEngine.InputSystem;

public class InputControllerMenu : MonoBehaviour
{
    InputManager inputManager;
    public MenuManager menuManager;

    void Awake()
    {
        inputManager = new InputManager();
    }

    void OnEnable()
    {
        inputManager.Player.BackEscape.performed += BackMenu;
        inputManager.Player.BackEscape.Enable();
    }

    void OnDisable()
    {
        inputManager.Player.BackEscape.performed -= BackMenu;
        inputManager.Player.BackEscape.Disable();
    }

    void BackMenu(InputAction.CallbackContext obj)
    {
        menuManager.BackButton();
    }
}
