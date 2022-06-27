using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation_R2 : MonoBehaviour
{
    public float RotateR2 = 0.5f;
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.PageUp))
        {
            Quaternion Temp = transform.rotation * Quaternion.Euler(0, -RotateR2, 0);
            transform.rotation = Temp;
            Debug.Log(transform.rotation);
        }
        if (Input.GetKey(KeyCode.PageDown))
        {
            Quaternion Temp = transform.rotation * Quaternion.Euler(0, RotateR2, 0);
            transform.rotation = Temp;
            Debug.Log(transform.rotation);
        }
    }
}
