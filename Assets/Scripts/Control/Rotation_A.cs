using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation_A : MonoBehaviour
{
    public float RotateA = 1f;

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Quaternion Temp = transform.rotation * Quaternion.Euler(0, RotateA, 0);
            transform.rotation = Temp;
            Debug.Log(transform.rotation);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Quaternion Temp = transform.rotation * Quaternion.Euler(0, -RotateA, 0);
            transform.rotation = Temp;
            Debug.Log(transform.rotation);
        }
    }
}     