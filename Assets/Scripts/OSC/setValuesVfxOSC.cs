using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;
using Unity.Mathematics;
using NaughtyAttributes;

public class setValuesVfxOSC : MonoBehaviour
{

    [Header("VFX")]
    [SerializeField]
    private   List<VisualEffect> vfx;

    [Header("VFX Parameters")]
    public float minScale;
    public float maxScale;
    [SerializeField]
    [ReadOnly] private float fieldScale;
    public float minIntensity;
    public float maxIntensity;
    [SerializeField]
    [ReadOnly] private float noiseIntensity;
    public float minSpeed;
    public float maxSpeed;
    [SerializeField]
    [ReadOnly] private float noiseSpeed;
    public float minFrequency;
    public float maxFrequency;
    [SerializeField]
    [ReadOnly] private float noiseFrequency;


    public float minSize;
    public float maxSize;
    [SerializeField]
    [ReadOnly] private float size;

    [SerializeField]
    [ReadOnly] private bool useAlpha;

    #region Private Fields
    [SerializeField]
    [ReadOnly] private float midiMin=0.0f;
    [SerializeField]
    [ReadOnly] private float midiMax=1.0f;

    #endregion
    void Start()
    {
        
    }


    void Update()
    {
        
    }

    void UpdateValues()
    {
        for(int i = 0; i < vfx.Count; i++)
        {
            if (vfx[i] != null)
            {

            }
        }
    }

    void SetValuesOSC(float f)
    {

    }

    public void SetNoiseIntensity(float i, VisualEffect vfx)
    {
        noiseIntensity = math.remap(midiMin, midiMax, 0.001f, maxIntensity, i);
        vfx.SetFloat("CellularNoiseIntensity", noiseIntensity);
    }

    public void SetFieldScale(float i, VisualEffect vfx)
    {
        fieldScale = math.remap(midiMin, midiMax, 0.001f, maxScale, i);
        vfx.SetFloat("FieldScale", fieldScale);
    }

    public void SetNoiseSpeed(float i, VisualEffect vfx)
    {
        noiseSpeed = math.remap(midiMin, midiMax, 0.001f, maxSpeed, i);
        vfx.SetFloat("NoiseSpeed", noiseSpeed);
    }

    public void SetNoiseFrequency(float i, VisualEffect vfx)
    {
        noiseFrequency = math.remap(midiMin, midiMax, 0.001f, maxFrequency, i);
        vfx.SetFloat("NoiseFrequency", noiseFrequency);
    }
    public void SetSize(float i, VisualEffect vfx)
    {
        size = math.remap(midiMin, midiMax, minSize, maxSize, i);
        vfx.SetFloat("Scale", size);
    }

    public void HandleAlpha(float i, VisualEffect vfx)
    {
        useAlpha = !useAlpha;
        vfx.SetBool("UseAlphaNoise", useAlpha);
    }
}
