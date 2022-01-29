using UnityEngine;

public class CharactersManager : MonoBehaviour
{
    public GameObject[] characters;
    int i = 0;

    Animator[] dialogues;

    public void PlayDialogue()
    {
        if (i < characters.Length - 1)
        {
            i++;
            characters[i - 1].SetActive(false);
            characters[i].SetActive(true);
        }
    }
}
