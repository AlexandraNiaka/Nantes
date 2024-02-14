using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OscResetCamera : MonoBehaviour
{

    [SerializeField]
    private GameObject[] cameras;
    public void ResetTransform()
    {
        print("reset");
        for(int i=0; i < cameras.Length; i++)
        {
            cameras[i].transform.position = Vector3.zero;
            cameras[i].transform.rotation = Quaternion.identity;
        }
    }
}
