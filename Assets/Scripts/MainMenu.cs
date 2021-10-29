using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour {
    public string playGameLevel;
    public string playGameLevelEasy;
    public string playGameLevelHard;


    public void PlayGame()
    {

        Application.LoadLevel(playGameLevel);
    }

    public void QuitGame()
    {
        Application.Quit();

    }
    public void PlayEasy()
    {

        Application.LoadLevel(playGameLevelEasy);
    }
    public void PlayHard()
    {

        Application.LoadLevel(playGameLevelHard);
    }
}
