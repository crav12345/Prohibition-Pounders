using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReactionHit : MonoBehaviour
{
    public GameObject player;
    public GameObject enemy;
    public GameObject img;
    public GameObject newParent;
    BeatObject beatObject;

    // TO KEEP THINGS CLEANER, NOT NECESSARILY EASIER
    // TODO:
    /** ideas:
     * spawn reaction img over head (width: 150     height: 50)
     * if within range of player, then you have 3 seconds to hit
     * hits are either perfect or miss
     * FOR KEYBOARD -- tags are the shoulder and trigger buttons (space)
    **/

    void Awake()
    {
        player = GameObject.Find("Player");
        enemy = gameObject;
    }

    void Start()
    {

    }

    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            Debug.Log("collied");

            img.SetActive(true);
            enemy.transform.SetParent(newParent.transform);
        }

        //if (col.tag == "Reaction")
        //{
        //    Debug.Log("reaction 666");
        //}
    }

    public void OnTriggerExit2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            Debug.Log("collide exti");
        }
    }
}
