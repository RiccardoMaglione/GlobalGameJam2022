using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public GameObject PanelMainMenu;
    public GameObject PanelOption;
    public GameObject PanelCredits;

    public Image ImagePlayButton;
    public Image ImageOptionButton;
    public Image ImageCreditsButton;

    public Sprite SpritePlayDehover;
    public Sprite SpriteOptionDehover;
    public Sprite SpriteCreditsDehover;

    public GameObject FirePlay;
    public GameObject FireOption;
    public GameObject FireCredits;
    public GameObject FireExit;

    public void PlayButton(string NameScene)
    {
        DeactivateFire();
        SceneManager.LoadScene(NameScene);
    }
    public void OptionButton()
    {
        ImageOptionButton.sprite = SpriteOptionDehover;

        PanelOption.SetActive(true);
        PanelCredits.SetActive(false);
        PanelMainMenu.SetActive(false);

        DeactivateFire();
    }
    public void CreditsButton()
    {
        ImageCreditsButton.sprite = SpriteCreditsDehover;

        PanelCredits.SetActive(true);
        PanelOption.SetActive(false);
        PanelMainMenu.SetActive(false);

        DeactivateFire();
    }

    public void BackButton()
    {
        ImagePlayButton.sprite = SpritePlayDehover;

        PanelCredits.SetActive(false);
        PanelOption.SetActive(false);
        PanelMainMenu.SetActive(true);

        DeactivateFire();
    }

    public void DeactivateFire()
    {
        FirePlay.SetActive(false);
        FireOption.SetActive(false);
        FireCredits.SetActive(false);
        FireExit.SetActive(false);
    }

    public void Quit()
    {
        Application.Quit();
    }

}
