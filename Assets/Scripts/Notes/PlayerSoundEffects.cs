using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSoundEffects : MonoBehaviour
{
    public AudioSource audio;
    public AudioClip[] clips;

    void Start()
    {
        audio = GetComponent<AudioSource>();
    }
}
