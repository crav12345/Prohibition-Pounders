using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //public bool isSteve;
    //public bool isToni;

    [Header("Steve Game Objects")]
    public GameObject steveGO;
    public GameObject steveWalkGO;
    public GameObject steveHurtGO;
    public GameObject steveAttackGO;

    [Header("Toni Game Objects")]
    public GameObject toniGO;
    public GameObject toniWalkGO;
    public GameObject toniHurtGO;
    public GameObject toniAttackGO;

    [Header("Player Controls")]
    public bool isHit;
    public bool isAttacking;

    MainMenuScript mainMenu;

    void Start()
    {
        //MainMenuScript mainMenu;

        //mainMenu = GameObject.Find("MenuController").GetComponent<MainMenuScript>();
        ////MainMenuScript.isSteve = isSteve;
        ////MainMenuScript.isToni = isToni;

        ////string isToni = PlayerPrefs.GetString("Toni");
        ////string isSteve = PlayerPrefs.GetString("Steve");

        ////GameObject playerName = gameObject;

        //if (PlayerPrefs.GetString(mainMenu.player) == "Toni")
        //{
        //    Debug.Log("toni");
        //}
        //else
        //{
        //    Debug.Log("steve");
        //}
    }

    void Update()
    {
        if (isHit)
        {
            StartCoroutine(PlayAnimInterval(6, 1f));

            steveWalkGO.SetActive(true);
            steveAttackGO.SetActive(false);
            steveHurtGO.SetActive(false);

            isHit = false;
        }

        if (isAttacking)
        {
            StartCoroutine(PlayAnimInterval(6, 1f));

            steveWalkGO.SetActive(true);
            steveHurtGO.SetActive(false);
            steveAttackGO.SetActive(false);

            isAttacking = false;
        }
    }

    private IEnumerator PlayAnimInterval(int n, float time)
    {
        if (isHit)
        {
            while (n > 0)
            {
                steveWalkGO.SetActive(false);
                steveAttackGO.SetActive(false);
                steveHurtGO.SetActive(true);

                --n;
                yield return new WaitForSeconds(time);
            }
        }

        if (isAttacking)
        {
            while (n > 0)
            {
                steveWalkGO.SetActive(false);
                steveHurtGO.SetActive(false);
                steveAttackGO.SetActive(true);

                --n;
                yield return new WaitForSeconds(time);
            }
        }
    }
}
