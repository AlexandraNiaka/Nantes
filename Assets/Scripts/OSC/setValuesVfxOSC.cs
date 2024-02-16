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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
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
}
