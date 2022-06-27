using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation_R3 : MonoBehaviour
{
    public float RotateR3 = 0.5f;
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Home))
        {
            Quaternion Temp = transform.rotation * Quaternion.Euler(0, -RotateR3, 0);
            transform.rotation = Temp;
            Debug.Log(transform.rotation);
        }
        if (Input.GetKey(KeyCode.End))
        {
            Quaternion Temp = transform.rotation * Quaternion.Euler(0, RotateR3, 0);
            transform.rotation = Temp;
            Debug.Log(transform.rotation);
        }
    }
}
