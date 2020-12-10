using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class BeatCounter : MonoBehaviour
{
    #region Variables
    public static BeatCounter instance;                 // instance of game logic
    public AudioSource audioSource;
    public bool isStarted;                              // checks if audio has begun
    private float delay = 1;
    private float timer;

    [Header("Scoring")]
    public GameObject[] beatCount;
    public int currScore;
    private int scorePerOkBeat = 100;
    private int scorePerGreatBeat = 125;
    private int scorePerPerfectBeat = 150;
    public int currMultiplier;
    private int multiplierTracker;
    public int[] multiplierThresholds;
    private int okBeats;
    private int greatBeats;
    private int perfectBeats;
    private int missedBeats;
    
    // NEW HEALTH SYSTEM PROTOTYPE //
    private int playerHealth;
    private bool canIncrementFlag;
    private System.DateTime startTime;
    private System.TimeSpan timeDifference;
    private System.TimeSpan waitTime;
    private bool hasDied = false;
    public Slider healthBar;
    /////////////////////////////////////

    private bool paused = false;
    private bool canIncreaseVolumeFlag;
    private System.DateTime volStartTime;
    private System.TimeSpan volTimeDifference;
    private System.TimeSpan volWaitTime;


    [Header("UI Components")]
    // during game
    public TMP_Text scoreTxt;
    public TMP_Text multiplierTxt;
    public TMP_Text hitQualityTxt;
    // post game
    public GameObject resultsScreen;
    public GameObject restartButton;
    public GameObject nextButton;
    public TMP_Text scoreFinalTxt;
    public TMP_Text percentageTxt;
    public TMP_Text rankTxt;
    public TMP_Text okTxt;
    public TMP_Text greatTxt;
    public TMP_Text perfectTxt;
    public TMP_Text missedTxt;
    #endregion

    void Start()
    {
        instance = this;

        scoreTxt.text = "Score:      0";
        hitQualityTxt.text = "";
        currMultiplier = 1;

        // NEW HEALTH SYSTEM PROTOTYPE //
        playerHealth = 30;
        waitTime = new System.TimeSpan(5000000);
        /////////////////////////////////

        volWaitTime = new System.TimeSpan(1000000);

        timer = delay;

        for (int i = 0; i < beatCount.Length; i++)
        {
            if (i == 0)
                beatCount[i] = GameObject.Find("Note");
            else
                beatCount[i] = GameObject.Find("Note (" + i + ")");
        }
    }

    void Update()
    {
        if (!isStarted)
        {
            isStarted = true;
            audioSource.Play();
        }
        else
        {
            if (!audioSource.isPlaying && !resultsScreen.activeInHierarchy && !paused)
            {
                timer += Time.deltaTime;

                if (timer > 5)
                {
                    resultsScreen.SetActive(true);
                    Debug.Log("end game");
                }

                ResultsScreenTexts();
            }
        }

        // NEW HEALTH SYSTEM PROTOTYPE //
        if (playerHealth < 30 && canIncrementFlag && !paused)
        {
            playerHealth++;
            startTime = System.DateTime.Now;
            canIncrementFlag = false;
        }

        timeDifference = System.DateTime.Now - startTime;

        if (System.TimeSpan.Compare(timeDifference, waitTime) == 1 && !canIncrementFlag)
            canIncrementFlag = true;

        healthBar.value = playerHealth;

        if (playerHealth > 0)
        {
            hasDied = false;
        }
        else if (playerHealth <= 0)
        {
            hasDied = true;
            restartButton.SetActive(true);
            nextButton.SetActive(false);
        }
        /////////////////////////////////

        if (Input.GetKeyDown(KeyCode.P))
        {
            if (audioSource.isPlaying)
            {
                paused = true;
                audioSource.Pause();
            }
            else
            {
                audioSource.UnPause();
                paused = false;
            }
        }

        //Debug.Log(audioSource.volume);
        if (audioSource.volume < 1f && canIncreaseVolumeFlag && !paused)
        {
            Debug.Log("Turn it up");
            audioSource.volume += 0.1f;
            volStartTime = System.DateTime.Now;
            canIncreaseVolumeFlag = false;
        }

        volTimeDifference = System.DateTime.Now - volStartTime;

        if (System.TimeSpan.Compare(volTimeDifference, volWaitTime) == 1 && !canIncreaseVolumeFlag)
            canIncreaseVolumeFlag = true;
    }

    #region Beat checks
    public void BeatHit()
    {
        //Debug.Log("Hit");

        if (currMultiplier - 1 < multiplierThresholds.Length)
        {
            multiplierTracker++;

            if (multiplierThresholds[currMultiplier - 1] <= multiplierTracker)
            {
                multiplierTracker = 0;
                currMultiplier++;
            }
        }

        multiplierTxt.text = "Multiplier:   x" + currMultiplier;
        scoreTxt.text = "Score:     " + currScore;
    }

    public void OkHit()
    {
        Debug.Log("Ok hit");

        hitQualityTxt.color = Color.yellow;
        hitQualityTxt.text = "OK";
        currScore += scorePerOkBeat * currMultiplier;
        BeatHit();
        okBeats++;
    }

    public void GreatHit()
    {
        Debug.Log("Great hit");

        hitQualityTxt.color = Color.blue;
        hitQualityTxt.text = "GREAT";
        currScore += scorePerGreatBeat * currMultiplier;
        BeatHit();
        greatBeats++;
    }

    public void PerfectHit()
    {
        Debug.Log("Perfect hit");

        hitQualityTxt.color = Color.green;
        hitQualityTxt.text = "PERFECT";
        currScore += scorePerPerfectBeat * currMultiplier;
        BeatHit();
        perfectBeats++;
    }

    public void BeatMiss()
    {
        hitQualityTxt.color = Color.red;
        hitQualityTxt.text = "MISSED";
        currMultiplier = 1;
        multiplierTracker = 0;
        multiplierTxt.text = "Multiplier:   x" + currMultiplier;

        missedBeats++;

        // New health system
        playerHealth -= 10;

        // Debug.Log("Misses: " + missedBeats);
        audioSource.volume = 0.1f;

        //* NEW HEALTH SYSTEM
        if (playerHealth <= 0)
        {
            //paused = true;
            audioSource.Stop();
            Destroy(GameObject.Find("Notes"));
            Destroy(GameObject.Find("HUDText"));
            Destroy(GameObject.Find("Chords"));
            Destroy(GameObject.Find("HealthBar"));
        }
    }
    #endregion

    #region Results
    private void ResultsScreenTexts()
    {
        okTxt.text = "" + okBeats;
        greatTxt.text = "" + greatBeats;
        perfectTxt.text = "" + perfectBeats;
        missedTxt.text = "" + missedBeats;

        float hitCount = okBeats + greatBeats + perfectBeats;
        float percentCount = (hitCount / beatCount.Length) * 100f;

        percentageTxt.text = percentCount.ToString("F1") + "%";

        ResultsScreenRank(percentCount);

        scoreFinalTxt.text = "" + currScore;
    }

    private void ResultsScreenRank(float percentCount)
    {
        if (percentCount == 100)
        {
            rankTxt.text = "SSS";
        }
        else if (percentCount > 97)
        {
            rankTxt.text = "SS";
        }
        else if (percentCount > 95)
        {
            rankTxt.text = "S";
        }
        else if (percentCount > 90)
        {
            rankTxt.text = "A";
        }
        else if (percentCount > 80)
        {
            rankTxt.text = "B";
        }
        else if (percentCount > 70)
        {
            rankTxt.text = "C";
        }
        else if (percentCount > 60)
        {
            rankTxt.text = "D";
        }
        else
        {
            rankTxt.text = "F";
        }
    }

    public void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void NextScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void ReturnToMenu()
    {
        SceneManager.LoadScene(0);
    }
    #endregion
}
