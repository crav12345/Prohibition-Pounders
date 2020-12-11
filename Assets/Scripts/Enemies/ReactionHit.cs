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
    public BeatObject beatObject;

    void Awake()
    {
        player = GameObject.Find("Player");
        enemy = gameObject;

        beatObject = gameObject.transform.GetComponentInChildren<BeatObject>();
    }

    void Start()
    {

    }

    void Update()
    {

    }

    public void DestroyReaction()
    {
        if (beatObject.IsReaction() == true)
        {
            //Debug.Log("react was hit");
            Destroy(gameObject);
        }
    }

    public void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            //Debug.Log("collied");

            img.SetActive(true);
            enemy.transform.SetParent(newParent.transform);
        }
    }

    public void OnTriggerExit2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            //Debug.Log("collide exti");
        }
    }
}
