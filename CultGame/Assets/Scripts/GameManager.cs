using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public static GameManager Instance;

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
    }
}
