﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public Transform platformGenerator;
    private Vector3 platformStartPoint;

    public PlayerControl thePlayer;
    private Vector3 playerStartPoint;

   

    private PlatformDestroyer[] platformList;

    private ScoreManager theScoreManager;

    public DeathMenu deathScreen;
    // Use this for initialization
	void Start () {

        platformStartPoint = platformGenerator.position;
        playerStartPoint = thePlayer.transform.position;

        theScoreManager = FindObjectOfType<ScoreManager>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void RestartGame()
    {
        //StartCoroutine("RestartGameCo");
        theScoreManager.scoreIncreasing = false;
        thePlayer.gameObject.SetActive(false);
        deathScreen.gameObject.SetActive(true);
    }
    public void Reset()
    {
        deathScreen.gameObject.SetActive(false);
        platformList = FindObjectsOfType<PlatformDestroyer>();
        for (int i = 0; i < platformList.Length; i++)
        {

            platformList[i].gameObject.SetActive(false);
        }
        platformGenerator.position = platformStartPoint;

        thePlayer.transform.position = playerStartPoint;
        thePlayer.gameObject.SetActive(true);

        theScoreManager.scoreCount = 0;
        theScoreManager.scoreIncreasing = true;
    }
    /*public IEnumerator RestartGameCo()
    {
        theScoreManager.scoreIncreasing = false;
        thePlayer.gameObject.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        platformList = FindObjectsOfType<PlatformDestroyer>();
        for(int i = 0; i < platformList.Length; i++)
        {

            platformList[i].gameObject.SetActive(false);
        }
        platformGenerator.position = platformStartPoint;
        
        thePlayer.transform.position = playerStartPoint;
        thePlayer.gameObject.SetActive(true);

        theScoreManager.scoreCount = 0;
        theScoreManager.scoreIncreasing = true;
    }*/
}
