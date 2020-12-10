/// 
/// This script must run last in the Script Execution Order settings.
/// 

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonMashHandler : MonoBehaviour
{
    public int currScore;
    public int scoreIncreaseCheck;
    public Slider playerHealth;

    private GameObject audioSource;
    private BeatCounter beatCounter;

    private void Start()
    {
        audioSource = GameObject.Find("Audio Source");
        beatCounter = audioSource.GetComponent<BeatCounter>();

        currScore = beatCounter.currScore;

        scoreIncreaseCheck = currScore + 1;
    }

    // Update is called once per frame
    void Update()
    {
        currScore = beatCounter.currScore;

        if (Input.GetKeyDown(KeyCode.W)
            || Input.GetKeyDown(KeyCode.A)
            || Input.GetKeyDown(KeyCode.S)
            || Input.GetKeyDown(KeyCode.D)
            || Input.GetKeyDown(KeyCode.Y)
            || Input.GetKeyDown(KeyCode.U)
            || Input.GetKeyDown(KeyCode.I)
            || Input.GetKeyDown(KeyCode.O))
        {
            if (isRandom())
                BeatMiss();
        }

        scoreIncreaseCheck = currScore + 1;
    }

    // Check if a button press hits a beat
    private bool isRandom()
    {
        if (scoreIncreaseCheck > currScore)
            return true;
        else
            return false;
    }

    // Should lower the player's health
    private void BeatMiss()
    {
        beatCounter.BeatMiss();
    }
}
