using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //public bool isSteve;
    //public bool isToni;

    [Header("Player Model Game Objects")]
    private GameObject steve;
    private GameObject toni;
    private GameObject playerModel;

    [Header("Player Model Anims")]
    private GameObject walk;
    private GameObject attack;
    private GameObject hurt;

    [Header("Player Controls")]
    public bool isHit;
    public bool isAttacking;


    void Start()
    {
        steve = transform.Find("Steve").gameObject;
        toni = transform.Find("Toni").gameObject;

        if (PlayerPrefs.GetString("Character", "No name") == "Toni")
        {
            toni.SetActive(true);
            playerModel = toni;
            walk = playerModel.transform.Find("PlayerModel_Toni").gameObject;
            attack = playerModel.transform.Find("PlayerModel_Toni_Attack").gameObject;
            hurt = playerModel.transform.Find("PlayerModel_Toni_Hurt").gameObject;
        }
        else
        {
            steve.SetActive(true);
            playerModel = steve;
            walk = playerModel.transform.Find("PlayerModel_Steve").gameObject;
            attack = playerModel.transform.Find("PlayerModel_Steve_Attack").gameObject;
            hurt = playerModel.transform.Find("PlayerModel_Steve_Hurt").gameObject;
        }
    }

    public void hurtPlayer()
    {
        StartCoroutine(waiter(hurt));
    }

    public void attackEnemy()
    {
        StartCoroutine(waiter(attack));
    }

    IEnumerator waiter(GameObject newAnim)
    {
        // Switch to desired anim
        walk.SetActive(false);
        newAnim.SetActive(true);

        // Wait for a second
        yield return new WaitForSeconds(1);

        // Switch back
        newAnim.SetActive(false);
        walk.SetActive(true);
    }
}
