using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

[System.Serializable]
public class RGBStretchEffect : VolumeComponent, IPostProcessComponent
{
    public ClampedFloatParameter stretchFactor = new ClampedFloatParameter(0f, 0f, 10f);

    public bool IsActive() => stretchFactor.value > 0f;
    public bool IsTileCompatible() => false;
}
