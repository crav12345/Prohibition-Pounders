using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class BeatObject : MonoBehaviour
{
    public bool isHit;                      // checks if button was pressed
    PlayerControls controls;
    public GameObject noteCatcher;
    public int isAlive;
    public ButtonType buttonType;
    public Image buttonImg;
    public PlayerSoundEffects soundEffects;
    public GameObject particleEffect;
    private ReactionHit reactionHit;

    void Awake()
    {
        noteCatcher = GameObject.Find("Note Catcher");

        controls = new PlayerControls();

        isAlive = 1;

        controls.Gameplay.FaceButtons.performed += ctx => FaceButtonCheck();
        controls.Gameplay.DirectionalButtons.performed += ctx => DirectionalButtonCheck();
        controls.Gameplay.ShoulderButtons.performed += ctx => ShoulderButtonCheck();
        //controls.Gameplay.AnalogSticks.performed += ctx => AnalogStickCheck(ctx.ReadValue<Vector2>());
    }

    void OnEnable()
    {
        controls.Gameplay.Enable();
    }

    void OnDisable()
    {
        controls.Gameplay.Disable();
    }

    void Start()
    {   
        buttonImg = gameObject.GetComponent<Image>();

        buttonTypeCheck();

        reactionHit = gameObject.GetComponentInParent<ReactionHit>();
    }

    void Update()
    {
        keyboardCheck();
    }

    #region Button Checks
    void buttonTypeCheck()
    {
        //InputSystem.onDeviceChange += (device, change) =>
        //{
        //    switch (change)
        //    {
        //        case InputDeviceChange.Added:
        //            Debug.Log("Controller connected");
        //            break;
        //        case InputDeviceChange.Removed:
        //            Debug.Log("Keyboard defaulted");
        //            break;
        //    }
        //};


        //if (Input.GetJoystickNames().Length > 0)
        //{
        //    Debug.Log("Controller connected");
        //    switch (gameObject.tag)
        //    {
        //        case "FaceButton_X":
        //            buttonImg.sprite = buttonType.faceButton_X;
        //            break;
        //        case "FaceButton_O":
        //            buttonImg.sprite = buttonType.faceButton_O;
        //            break;
        //        case "FaceButton_Tri":
        //            buttonImg.sprite = buttonType.faceButton_Tri;
        //            break;
        //        case "FaceButton_Sq":
        //            buttonImg.sprite = buttonType.faceButton_Sq;
        //            break;
        //        case "FaceButton_Up":
        //            buttonImg.sprite = buttonType.faceButton_Up;
        //            break;
        //        case "FaceButton_Down":
        //            buttonImg.sprite = buttonType.faceButton_Down;
        //            break;
        //        case "FaceButton_Left":
        //            buttonImg.sprite = buttonType.faceButton_Left;
        //            break;
        //        case "FaceButton_Right":
        //            buttonImg.sprite = buttonType.faceButton_Right;
        //            break;
        //        case "FaceButton_LShoulder":
        //            buttonImg.sprite = buttonType.faceButton_LShoulder;
        //            break;
        //        case "FaceButton_RShoulder":
        //            buttonImg.sprite = buttonType.faceButton_RShoulder;
        //            break;
        //        case "FaceButton_LTrigger":
        //            buttonImg.sprite = buttonType.faceButton_LTrigger;
        //            break;
        //        case "FaceButton_RTrigger":
        //            buttonImg.sprite = buttonType.faceButton_RTrigger;
        //            break;
        //        case "FaceButton_LStick":
        //            buttonImg.sprite = buttonType.faceButton_LStick;
        //            break;
        //        case "FaceButton_RStick":
        //            buttonImg.sprite = buttonType.faceButton_RStick;
        //            break;
        //    }
        //} else
        //{
        // Debug.Log("Leyboard");
        switch (gameObject.tag)
        {
            case "FaceButton_X":
                buttonImg.sprite = buttonType.keyboardButton_Y;
                break;
            case "FaceButton_O":
                buttonImg.sprite = buttonType.keyboardButton_U;
                break;
            case "FaceButton_Tri":
                buttonImg.sprite = buttonType.keyboardButton_I;
                break;
            case "FaceButton_Sq":
                buttonImg.sprite = buttonType.keyboardButton_O;
                break;
            case "FaceButton_Up":
                buttonImg.sprite = buttonType.keyboardButton_W;
                break;
            case "FaceButton_Down":
                buttonImg.sprite = buttonType.keyboardButton_S;
                break;
            case "FaceButton_Left":
                buttonImg.sprite = buttonType.keyboardButton_A;
                break;
            case "FaceButton_Right":
                buttonImg.sprite = buttonType.keyboardButton_D;
                break;
            case "FaceButton_LShoulder":
                buttonImg.sprite = buttonType.keyboardButton_Space;
                break;
            case "FaceButton_RShoulder":
                buttonImg.sprite = buttonType.keyboardButton_Space;
                break;
            case "FaceButton_LTrigger":
                buttonImg.sprite = buttonType.keyboardButton_Space;
                break;
            case "FaceButton_RTrigger":
                buttonImg.sprite = buttonType.keyboardButton_Space;
                break;
            case "FaceButton_LStick":
                buttonImg.sprite = buttonType.keyboardButton_LMouse;
                break;
            case "FaceButton_RStick":
                buttonImg.sprite = buttonType.keyboardButton_RMouse;
                break;
        }
        //}
    }

    public void keyboardCheck()
    {
        /** Checks for arrow pad/WASD directionals and angle of beat object
         * if direction lines up with angle,
         * if it was hit
         * destroy object instance
        **/
        if ((Input.GetKeyDown(KeyCode.W)) && (gameObject.tag == "FaceButton_Up"))
        {
            //Debug.Log("W");
            IsHit();
        }
        else if ((Input.GetKeyDown(KeyCode.S)) && (gameObject.tag == "FaceButton_Down"))
        {
            //Debug.Log("S");
            IsHit();
        }
        else if ((Input.GetKeyDown(KeyCode.A)) && (gameObject.tag == "FaceButton_Left"))
        {
            //Debug.Log("A");
            IsHit();
        }
        else if ((Input.GetKeyDown(KeyCode.D)) && (gameObject.tag == "FaceButton_Right"))
        {
            //Debug.Log("D");
            IsHit();
        }

        if ((Input.GetKeyDown(KeyCode.Y)) && (gameObject.tag == "FaceButton_X"))
        {
            //Debug.Log("Y");
            IsHit();
        } else if ((Input.GetKeyDown(KeyCode.U)) && (gameObject.tag == "FaceButton_O"))
        {
            //Debug.Log("U");
            IsHit();
        } else if ((Input.GetKeyDown(KeyCode.I)) && (gameObject.tag == "FaceButton_Tri"))
        {
            //Debug.Log("I");
            IsHit();
        } else if ((Input.GetKeyDown(KeyCode.O)) && (gameObject.tag == "FaceButton_Sq"))
        {
            //Debug.Log("O");
            IsHit();
        }

        if ((Input.GetKeyDown(KeyCode.Space)) && (gameObject.tag == "FaceButton_LShoulder"))
        {
            Debug.Log("Space");
            IsReaction();
            DestroyReaction();
        }
        //if ((Input.GetKeyDown(KeyCode.Space)) && (gameObject.tag == "FaceButton_LShoulder"))
        //{
        //    Debug.Log("Left Shoulder");
        //    IsHit();
        //}
        //else if ((Input.GetKeyDown(KeyCode.Space)) && (gameObject.tag == "FaceButton_RShoulder"))
        //{
        //    Debug.Log("Right Shoulder");
        //    IsHit();
        //}
        //else if ((Input.GetKeyDown(KeyCode.Space)) && (gameObject.tag == "FaceButton_LTrigger"))
        //{
        //    Debug.Log("Left Trigger");
        //    IsHit();
        //}
        //else if ((Input.GetKeyDown(KeyCode.Space)) && (gameObject.tag == "FaceButton_RTrigger"))
        //{
        //    Debug.Log("Right Trigger");
        //    IsHit();
        //}
    }

    void FaceButtonCheck()
    {
        if (controls.Gameplay.FaceButtons.ReadValue<Vector2>() == new Vector2(1, 0))
        {
            Debug.Log("O");
            IsHit();
        }
        if (controls.Gameplay.FaceButtons.ReadValue<Vector2>() == new Vector2(0, 1))
        {
            Debug.Log("Triangle");
            IsHit();
        }
        if (controls.Gameplay.FaceButtons.ReadValue<Vector2>() == new Vector2(-1, 0))
        {
            Debug.Log("Square");
            IsHit();
        }
        if (controls.Gameplay.FaceButtons.ReadValue<Vector2>() == new Vector2(0, -1))
        {
            Debug.Log("X");
            IsHit();
        }
    }

    void DirectionalButtonCheck()
    {
        if (controls.Gameplay.DirectionalButtons.ReadValue<Vector2>() == new Vector2(1, 0))
        {
            Debug.Log("Right");
            IsHit();
        }
        if (controls.Gameplay.DirectionalButtons.ReadValue<Vector2>() == new Vector2(0, 1))
        {
            Debug.Log("Up");
            IsHit();
        }
        if (controls.Gameplay.DirectionalButtons.ReadValue<Vector2>() == new Vector2(-1, 0))
        {
            Debug.Log("Left");
            IsHit();
        }
        if (controls.Gameplay.DirectionalButtons.ReadValue<Vector2>() == new Vector2(0, -1))
        {
            Debug.Log("Down");
            IsHit();
        }
    }

    void ShoulderButtonCheck()
    {
        if (controls.Gameplay.ShoulderButtons.ReadValue<Vector2>() == new Vector2(1, 0))
        {
            Debug.Log("Right shoulder");
            IsHit();
        }
        if (controls.Gameplay.ShoulderButtons.ReadValue<Vector2>() == new Vector2(0, 1))
        {
            Debug.Log("Left shoulder");
            IsHit();
        }
        if (controls.Gameplay.ShoulderButtons.ReadValue<Vector2>() == new Vector2(-1, 0))
        {
            Debug.Log("Right trigger");
            IsHit();
        }
        if (controls.Gameplay.ShoulderButtons.ReadValue<Vector2>() == new Vector2(0, -1))
        {
            Debug.Log("Left trigger");
            IsHit();
        }
    }

    void AnalogStickCheck(Vector2 dir)
    {
        Debug.Log(dir);
        IsHit();
    }
    #endregion

    #region Beat Checks
    private void IsHit()
    {
        if (isHit)
        {
            BeatCheck();
            isAlive = 0;
            Destroy(gameObject);
        }
    }

    public bool IsReaction()
    {
        if (isHit)
        {
            Debug.Log("absolute unit");
            BeatCounter.instance.PerfectHit();
            Instantiate(particleEffect, transform.position, particleEffect.transform.rotation);

            soundEffects.audio.clip = soundEffects.clips[0];
            soundEffects.audio.Play();

            isAlive = 0;;
            Debug.Log(gameObject.transform.parent.name);
        }

        return true;
    }

    private void DestroyReaction()
    {
        reactionHit.DestroyReaction();
    }

    private void BeatCheck()
    {
        if (transform.position.x > noteCatcher.transform.position.x + 15 || transform.position.x < noteCatcher.transform.position.x - 15)
        {
            BeatCounter.instance.OkHit();
            Instantiate(particleEffect, transform.position, particleEffect.transform.rotation);

            soundEffects.audio.clip = soundEffects.clips[0];
            soundEffects.audio.Play();
        }
        else if (transform.position.x > noteCatcher.transform.position.x + 5 || transform.position.x < noteCatcher.transform.position.x - 5)
        {
            BeatCounter.instance.GreatHit();
            Instantiate(particleEffect, transform.position, particleEffect.transform.rotation);

            soundEffects.audio.clip = soundEffects.clips[0];
            soundEffects.audio.Play();
        }
        else
        {
            BeatCounter.instance.PerfectHit();
            Instantiate(particleEffect, transform.position, particleEffect.transform.rotation);

            soundEffects.audio.clip = soundEffects.clips[0];
            soundEffects.audio.Play();
        }
    }
    #endregion

    #region Beat Collisions
    public void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Activator")
        {
            isHit = true;
        }

        if (col.tag == "Reaction")
        {
            isHit = true;
            Debug.Log("reaction");
        }
    }

    public void OnTriggerExit2D(Collider2D col)
    {
        if (col.tag == "Activator" && isAlive == 1)
        {
            isHit = false;
            BeatCounter.instance.BeatMiss();

            soundEffects.audio.clip = soundEffects.clips[1];
            soundEffects.audio.Play();
        }

        if (col.tag == "Reaction" && isAlive == 1)
        {
            Debug.Log("missed enemy");
            isHit = false;
            BeatCounter.instance.BeatMiss();

            soundEffects.audio.clip = soundEffects.clips[1];
            soundEffects.audio.Play();
        }
    }
    #endregion
}
