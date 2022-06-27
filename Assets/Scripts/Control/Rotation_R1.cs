using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation_R1 : MonoBehaviour
{
    public float RotateR1 = 0.5f;
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Quaternion Temp = transform.rotation * Quaternion.Euler(0, -RotateR1, 0);
            transform.rotation = Temp;
            Debug.Log(transform.rotation);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Quaternion Temp = transform.rotation * Quaternion.Euler(0, RotateR1, 0);
            transform.rotation = Temp;
            Debug.Log(transform.rotation);
        }
    }
}
