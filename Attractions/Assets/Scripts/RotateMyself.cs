using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateMyself : MonoBehaviour
{
    public float Rx, Ry, Rz;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Rx * Time.deltaTime, Ry * Time.deltaTime, Rz * Time.deltaTime);
    }
}
