using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public static GameManager Instance;

    [SerializeField] Text nameText;

    [SerializeField] GameObject main;
    
    [SerializeField] GameObject WerewolfCharacter;
    [SerializeField] GameObject SnowInstructorCharacter;
    [SerializeField] GameObject LeprechaunCharacter;

    private GameState currentState;
    private SelectedMonster currentMonster;

    public enum GameState
    {
        MainMenu,
        CharacterSelection,
        Gameplay
    }

    public enum SelectedMonster
    {
        Werewolf,
        SnowInstructor,
        Leprechaun
    }

    void Awake()
    {
        //Singleton pattern
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }


    void Start () {
        currentState = GameState.MainMenu;
	}
	
	void Update () {
		
	}

    public void SetStateToSelection()
    {
        currentState = GameState.CharacterSelection;
    }

    public void SetStateToGameplay()
    {
        currentState = GameState.Gameplay;
    }

    public void SetSelectedMonster(SelectedMonster selected)
    {
        currentMonster = selected;
        UpdatePlayerCharacter();
    }

    public void UpdatePlayerCharacter()
    {
        if (currentMonster == SelectedMonster.Werewolf)
        {
            GameObject character = Instantiate(WerewolfCharacter);
            main.transform.SetParent(character.transform);
        } else if (currentMonster == SelectedMonster.SnowInstructor)
        {
            GameObject character = Instantiate(SnowInstructorCharacter);
            main.transform.SetParent(character.transform);
        } else if (currentMonster == SelectedMonster.Leprechaun)
        {
            GameObject character = Instantiate(LeprechaunCharacter);
            main.transform.SetParent(character.transform);
        }
    }

    public void AppendNameText(string givenText)
    {
        nameText.text = nameText.text + givenText;
    }
}
