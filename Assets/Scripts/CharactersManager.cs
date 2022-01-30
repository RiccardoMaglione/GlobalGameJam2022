using UnityEngine;


public class CharactersManager : MonoBehaviour
{
    public GameObject[] characters;
    InputController inputController;
    int i = 0;

    private void Awake()
    {
        inputController = FindObjectOfType<InputController>();
    }

    public void PlayDialogue()
    {
        if (i < characters.Length - 1)
        {
            i++;
            inputController.i++;
            characters[i - 1].SetActive(false);
            characters[i].SetActive(true);
        }
    }
}