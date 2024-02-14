using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OscActivate : MonoBehaviour
{
    [SerializeField]
    bool _active;
    [SerializeField]
    float receivedvalue;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Toggle()
    {
        _active =! _active;
    }
    public void Setvalue (float val)
    {
        receivedvalue = val;
    }
}
