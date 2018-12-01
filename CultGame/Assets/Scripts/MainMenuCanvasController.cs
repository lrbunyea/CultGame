using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuCanvasController : MonoBehaviour {
    [SerializeField] GameObject canvas;

    public void HideCanvas()
    {
        canvas.SetActive(false);
        GameManager.Instance.SetStateToSelection();
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
