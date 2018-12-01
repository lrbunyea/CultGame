using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterSelectCanvas : MonoBehaviour {
    [SerializeField] GameObject canvas;
    [SerializeField] Button nextButton;
    [SerializeField] Button prevButton;
    [SerializeField] Text monsterName;
    [SerializeField] Image monsterImage;
    [SerializeField] Sprite WerewolfSprite;
    [SerializeField] Sprite SnowInstructorSprite;
    [SerializeField] Sprite LeprechaunSprite;

    [SerializeField] GameManager.SelectedMonster currentSelection;

	void Start () {
        UpdateToWerewolf();
	}

    private void UpdateToWerewolf()
    {
        currentSelection = GameManager.SelectedMonster.Werewolf;
        monsterImage.GetComponent<Image>().sprite = WerewolfSprite;
        monsterName.text = "Werewolf";
    }

    private void UpdateToSnowInstructor()
    {
        currentSelection = GameManager.SelectedMonster.SnowInstructor;
        monsterImage.GetComponent<Image>().sprite = SnowInstructorSprite;
        monsterName.text = "SnowInstructor";
    }

    private void UpdateToLeprechaun()
    {
        currentSelection = GameManager.SelectedMonster.Leprechaun;
        monsterImage.GetComponent<Image>().sprite = LeprechaunSprite;
        monsterName.text = "Leprechaun";
    }

    public void NextMonster()
    {
        if (currentSelection == GameManager.SelectedMonster.Werewolf)
        {
            UpdateToSnowInstructor();
        }
        else if (currentSelection == GameManager.SelectedMonster.SnowInstructor)
        {
            UpdateToLeprechaun();
        }
        else if (currentSelection == GameManager.SelectedMonster.Leprechaun)
        {
            UpdateToWerewolf();
        }
    }

    public void PrevMonster()
    {
        if (currentSelection == GameManager.SelectedMonster.Werewolf)
        {
            UpdateToLeprechaun();
        }
        else if (currentSelection == GameManager.SelectedMonster.SnowInstructor)
        {
            UpdateToWerewolf();
        }
        else if (currentSelection == GameManager.SelectedMonster.Leprechaun)
        {
            UpdateToSnowInstructor();
        }
    }

    public void MonsterSelected()
    {
        GameManager.Instance.SetSelectedMonster(currentSelection);
        GameManager.Instance.SetStateToGameplay();
        canvas.SetActive(false);
    }
}
