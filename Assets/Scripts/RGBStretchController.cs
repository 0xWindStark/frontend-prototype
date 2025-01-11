using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class RGBStretchController : MonoBehaviour
{
    public Volume volume;
    private RGBStretchEffect rgbStretchEffect;
    public float slowTimeScale = 0.5f;  // Slow motion scale (0.5 means 50% of normal speed)
    public float transitionSpeed = 2f;  // Speed of transition for both time and effect

    void Start()
    {
        volume.profile.TryGet(out rgbStretchEffect);
    }

    void Update()
    {
        // If the spacebar is pressed, start the RGB effect and slow down time
        if (Input.GetKey(KeyCode.Space))
        {
            // Smoothly increase the RGB stretch effect
            rgbStretchEffect.stretchFactor.value = Mathf.Lerp(rgbStretchEffect.stretchFactor.value, 5f, Time.deltaTime * transitionSpeed);

            // Smoothly slow down the game time
            Time.timeScale = Mathf.Lerp(Time.timeScale, slowTimeScale, Time.deltaTime * transitionSpeed);
            Time.fixedDeltaTime = Time.timeScale * 0.02f; // Adjust fixed time step for physics
        }
        else
        {
            // Smoothly return the RGB stretch effect to normal
            rgbStretchEffect.stretchFactor.value = Mathf.Lerp(rgbStretchEffect.stretchFactor.value, 0f, Time.deltaTime * transitionSpeed);

            // Smoothly return the game time to normal
            Time.timeScale = Mathf.Lerp(Time.timeScale, 1f, Time.deltaTime * transitionSpeed);
            Time.fixedDeltaTime = Time.timeScale * 0.02f;
        }
    }
}
