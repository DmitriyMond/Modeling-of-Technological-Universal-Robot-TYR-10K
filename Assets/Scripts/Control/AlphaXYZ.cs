using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AlphaXYZ : MonoBehaviour
{
    public Button _Enter; 

    private string InputX;
    private string InputZ;

    float Alpha;
    float X1 = 0;
    float Z1 = -0.0002f;
    float X2;
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

    public void ReadStringZ(string Z)
    {
        InputZ = Z;
        Debug.Log(InputZ);
    }

    public void TaskOnClick()
    {
        X2 = Convert.ToSingle(InputX);
        Z2 = Convert.ToSingle(InputZ);
        //конвентирую введенное число в InputField в переменную float, чтобы использовать ее в коде
    }

    void FixedUpdate()
    {
        double cos = Math.Round((X1 * X2 + Z1 * Z2) / (Math.Sqrt(X1 * X1 + Z1 * Z1) * Math.Sqrt(X2 * X2 + Z2 * Z2)), 9);
        Alpha = Mathf.Acos((float)cos) * 180 / Mathf.PI;

        if (((X2 < X1) & (Z2 < Z1)) || ((X2 < X1) & (Z2 > Z1)) || (X2 == 0) || ((X2 < X1) & (Z2 == 0)))
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, Alpha, 0), Time.deltaTime * 2f);

        if (((X2 > X1) & (Z2 > Z1)) || ((X2 > X1) & (Z2 < Z1)) || ((X2 > X1) & (Z2 == 0)))
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, -Alpha, 0), Time.deltaTime * 2f);
    }
}






/*void FixedUpdate()
{
    if (((X2 < X1) & (Z2 < Z1)) || ((X2 < X1) & (Z2 > Z1)))
    {
        double cos = Math.Round((X1 * X2 + Z1 * Z2) / (Math.Sqrt(X1 * X1 + Z1 * Z1) * Math.Sqrt(X2 * X2 + Z2 * Z2)), 9);
        Alpha = Mathf.Acos((float)cos) * 180 / Mathf.PI;

        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, Alpha, 0), Time.deltaTime * 0.8f);
    }

    if (((X2 > X1) & (Z2 > Z1)) || ((X2 > X1) & (Z2 < Z1)))
    {
        double cos = Math.Round((X1 * X2 + Z1 * Z2) / (Math.Sqrt(X1 * X1 + Z1 * Z1) * Math.Sqrt(X2 * X2 + Z2 * Z2)), 9);
        Alpha = Mathf.Acos((float)cos) * 180 / Mathf.PI;

        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, -Alpha, 0), Time.deltaTime * 0.8f);
    }

    if ((X2 == 0) || (Z2 == 0))
    {
        double cos = Math.Round((X1 * X2 + Z1 * Z2) / (Math.Sqrt(X1 * X1 + Z1 * Z1) * Math.Sqrt(X2 * X2 + Z2 * Z2)), 9);
        Alpha = Mathf.Acos((float)cos) * 180 / Mathf.PI;

        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, Alpha, 0), Time.deltaTime * 0.8f);
    }
}*/



//float A1 = 0;
//float AlphaY1;
//float AlphaY2;

/*public void ReadStringInput(string A)
{
    AlphaInput = A;
    Debug.Log(AlphaInput);
}*/

/*if (Alpha > 0)
{
    //transform.rotation *= q;
    AlphaY1 = A1 + Alpha;
    transform.eulerAngles = new Vector3(0, AlphaY1, 0);
    AlphaY1 = A1;
}

if (Alpha < 0)
{
    //transform.rotation *= q;
    AlphaY2 = A1 - Alpha;
    transform.eulerAngles = new Vector3(0, AlphaY2, 0);
    AlphaY2 = A1;
}

if (Alpha == A1)
    return;*/


//transform.RotateAround(new Vector3(0, 0, 0), Alpha);

/*float Angle_A = Alpha  * 0.0174532f;                                //введенное число перевожу из градусы в радианы
Quaternion TempA = Quaternion.Euler(0, Angle_A, 0);                          //создаю переменную, которая можно сказать показывает, как в конечном счете должна повернуться фигура
Quaternion TempB = Quaternion.Euler(0, y, 0);                               //создаю переменную, которая считывает текущее положение фигуры
if (y < Angle_A)                                                            // если ("текущее" меньше "итогогового")
{
    TempB = transform.rotation * Quaternion.Euler(0, 0.1f, 0);              //производится поворт фигуры
    transform.rotation = TempB;                                              //присваивается новое текущее положение фигуры
    return;
}
if (y > Angle_A)                                                               // если ("текущее" больше "итогогового")
{
    TempB = transform.rotation * Quaternion.Euler(0, -0.1f, 0);
    transform.rotation = TempB;
    return;
}
*/


/*void Update()
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

    float Alpha = System.Convert.ToSingle(AlphaInput); 
    Quaternion TempA = transform.rotation * Quaternion.Euler(0, RotateA, 0);
    if (TempA.y <= Alpha)
    {
        transform.rotation = TempA;
        TempA *= Quaternion.Euler(0, RotateA, 0);
        return;
    }
}*/



/*private static double GetAngle(Point Machine, Point Destination)
{
    // Получим косинус угла по формуле
    double cos = Math.Round((Machine.X * Destination.X + Machine.Y * Destination.Y) / (Math.Sqrt(Machine.X * Machine.X + Machine.Y * Machine.Y) * Math.Sqrt(Destination.X * Destination.X + Destination.Y * Destination.Y)), 9);
    // Вернем arccos полученного значения (в радианах!)
    return Math.Acos(cos);
}
private static double ToDegrees(double Angle) => Angle * 180 / Math.PI;

private static double GetAngle(Point Machine, Point Destination)
    {
    double cos = Mathf.Round((Machine.X * Destination.X + Machine.Y * Destination.Y) / (Mathf.Sqrt(Machine.X * Machine.X + Machine.Y * Machine.Y) * Mathf.Sqrt(Destination.X * Destination.X + Destination.Y * Destination.Y)), 9);
    return Mathf.Acos(cos);
    }
private static double ToDegrees(double Angle) => Angle * 180 / Mathf.PI;
*/