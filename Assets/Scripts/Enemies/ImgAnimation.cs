using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImgAnimation : MonoBehaviour
{
    [Header("Sprites")]
    public Sprite[] sprites;                // sprites from sprite sheet
    [Header("Sprite Controls")]
    public int spritePerFrame = 6;          // how many sprites will play per frame
    public bool isLooping = true;           // will animation loop
    public bool isDestroyOnEnd = false;     // will object be destroyed at the end of animation
    private int index = 0;                  // index of sprite in array
    private Image img;                      // image
    private int frame = 0;                  // frames in sprite sheet

    void Awake()
    {
        img = GetComponent<Image>();
    }

    void Update()
    {
        if (!isLooping && index == sprites.Length)
        {
            return;
        }

        frame++;

        if (frame < spritePerFrame)
        {
            return;
        }

        img.sprite = sprites[index];
        frame = 0;
        index++;

        if (index >= sprites.Length)
        {
            if (isLooping)
            {
                index = 0;
            }

            if (isDestroyOnEnd)
            {
                Destroy(gameObject);
            }
        }
    }
}
