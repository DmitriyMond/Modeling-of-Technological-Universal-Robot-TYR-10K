using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class RadiusXYZ : MonoBehaviour
{
    public Button _Enter;

    private string InputX;
    private string InputY;
    private string InputZ;

    float X2;
    float Y2;
    float Z2;

    void Start()
    {
        Button _button = _Enter.GetComponent<Button>();
        _button.onClick.AddListener(TaskOnClick);
    }

    public void ReadStringX(string X)
    {
        InputX = X;
        Debug.Log(InputX);
    }
    public void ReadStringY(string Y)
    {
        InputY = Y;
        Debug.Log(InputY);
    }
    public void ReadStringZ(string Z)
    {
        InputZ = Z;
        Debug.Log(InputZ);
    }

    public void TaskOnClick()
    {
        X2 = Convert.ToSingle(InputX) / (10);
        Y2 = Convert.ToSingle(InputY);
        Z2 = Convert.ToSingle(InputZ) / (10);
    }

    void FixedUpdate()
    {
        if ((X2 == 0) & (Y2 == 0) & (Z2 == 0)) 
            return;
        else 
            transform.localPosition = new Vector3(X2, Y2, Z2);
    }
}




//float X1 = 0.01353221f;
//float Y1 = 8.219654f;
//float Z1 = -1.415665f;
//float X0 = 0.01353221f;
//float Y0 = 8.219654f;
//float Z0 = -1.415665f;

/*if ((X2 == 0) || (Y2 == 0) || (Z2 == 0))
{
    if (X2 == 0)
        transform.localPosition = new Vector3(0, Y2, Z2);

    if (Y2 == 0)
        transform.localPosition = new Vector3(X2, 0, Z2);

    if (Z2 == 0)
        transform.localPosition = new Vector3(X2, Y2, 0);

    X1 = X2;
    Y1 = Y2;
    Z1 = Z2;
}*/



/*if ((X1 == X0) & (Y1 == Y0) & (Z1 == Z0))
{
    transform.localPosition = new Vector3(X1, Y1, Z1);
}

if ((X2 != X1) || (Y2 != Y1) || (Z2 != Z1))
{
    transform.position = new Vector3(X2, Y2, Z2);
    X1 = X2;
    Y1 = Y2;
    Z1 = Z2;
}*/