using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatMovement : MonoBehaviour
{
    #region Variables
    public float tempo;
    public bool isStarted;
    #endregion

    void Start()
    {
        tempo = tempo / 60f;
    }

    void Update()
    {
        // throw an extra if inside when we know how we want to start a level
        if (!isStarted)
        {
            isStarted = true;
        } else
        {
            transform.position -= new Vector3(tempo * Time.deltaTime, 0f, 0f);
        }
    }
}
