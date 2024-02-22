using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAroundSelf : MonoBehaviour
{
    [SerializeField]
    public float x;
    [SerializeField]
    public float y;
    [SerializeField]
    public float z;

    private float xX;
    private float yY;
    private float zZ;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(xX, yY, zZ);
    }

    public void SetX(float f)
    {
        xX = x * f;
    }

    public void SetY(float f)
    {
        yY = y * f;
    }

    public void SetZ(float f)
    {
        zZ = z * f;
    }

}
