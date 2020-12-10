/// This script can be applied directly to the URP volume whose overrides
/// you will be adjusting. Detect the overrides you want to manipulate and set
/// their runtime values in the Start() method. These values can them be
/// manipulated in the Update() method.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class ColorChange : MonoBehaviour
{
    // GLOBAL VARIABLES

    private Volume myVolume;
    private ColorAdjustments colorAdjustments;
    private FilmGrain filmGrain;

    private GameObject audioSource;
    private BeatCounter beatCounter;

    // We want to manipulate the camera based on the multiplier threshold
    private int[] multiplierThresholds;
    private int prevMultiplier;

    // Should be enabled, but cannot be changed
    private const int RESPONSE = 0;
    private const string GRAINTYPE = "Large 01";

    // Wiggle room
    private const float MAX_INTENSITY = 1f;
    private const float MAX_CONTRAST = 30f;
    private const float MIN_SATURATION = -100f;

    // Amount we change each of the above values
    private float intAmtIncrease = 0f;
    private float conAmtIncrease = 0f;
    private float satAmtIncrease = 0f;

    // Start is called before the first frame update
    void Start()
    {
        // Detect the volume component on this gameobject
        myVolume = GetComponent<Volume>();

        // Create variables for the overrides we want to manipulate using
        // URP syntax.
        myVolume.profile.TryGet(out colorAdjustments);
        myVolume.profile.TryGet(out filmGrain);

        ///////////////////////////////////////////////////////////////////////
        // For Color Adjustments we use properties: contrast & saturation
        // For Film Grain we use properties: response, intensity, & grain type
        ///////////////////////////////////////////////////////////////////////
        
        // Find the object with the Beat Counter component and grab the
        // multiplier thresholds value. The maximum combo is the length + 1.
        // The values at each index are the score one must acquire to advance
        // to the next multiplier threshold. Also grab the currMultiplier so
        // we know what threshold we are at.
        audioSource = GameObject.Find("Audio Source");
        beatCounter = audioSource.GetComponent<BeatCounter>();
        multiplierThresholds = beatCounter.multiplierThresholds;

        intAmtIncrease = MAX_INTENSITY / multiplierThresholds.Length;
        conAmtIncrease = MAX_CONTRAST / multiplierThresholds.Length;
        satAmtIncrease = MIN_SATURATION / multiplierThresholds.Length;

        prevMultiplier = beatCounter.currMultiplier;

        // Set default values for runtime
        colorAdjustments.saturation.value = 0 - satAmtIncrease;
        colorAdjustments.contrast.value = 0 - conAmtIncrease;
        filmGrain.intensity.value = 0 - intAmtIncrease;
    }

    // Update is called once per frame
    void Update()
    {
        // Current multiplier increases, increase each by its respective amount.
        // Opposite if the multiplier decreases. Set previous multiplier
        // to the current multiplier.
        if (beatCounter.currMultiplier > prevMultiplier)
        {
            filmGrain.intensity.value += intAmtIncrease;
            colorAdjustments.contrast.value += conAmtIncrease;
            colorAdjustments.saturation.value += satAmtIncrease;

            prevMultiplier = beatCounter.currMultiplier;
        }
        else if (beatCounter.currMultiplier < prevMultiplier)
        {
            filmGrain.intensity.value = 0f;
            colorAdjustments.contrast.value = 0f;
            colorAdjustments.saturation.value = 0f;

            prevMultiplier = beatCounter.currMultiplier;
        }
    }
}
