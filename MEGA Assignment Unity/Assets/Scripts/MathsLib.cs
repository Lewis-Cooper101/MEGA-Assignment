using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MathsLib
{
    public static float VectorToRadians(Vector2 V) 
    {
        float rv = 0.0f;

        rv = Mathf.Atan(V.y / V.x);

        return rv;
    }

    public static Vector2 RadiansToVector(float angle) 
    {
        Vector2 rv = new Vector2(Mathf.Cos(angle), Mathf.Sin(angle));

        return rv;
    }

    public static MyVector3 EulerAnglesToDirection(MyVector3 EulerAngles)
    {
        MyVector3 rv = new MyVector3(0, 0, 0);

        rv.z = Mathf.Cos(EulerAngles.y) * Mathf.Cos(EulerAngles.x);
        rv.y = Mathf.Sin(EulerAngles.x);
        rv.x = Mathf.Cos(EulerAngles.x) * Mathf.Sin(EulerAngles.y);

        return rv;
    }

    public static MyVector3 VectorCrossProduct(MyVector3 A, MyVector3 B) 
    {
        MyVector3 C = new MyVector3(0, 0, 0);

        C.x = A.y * B.z - A.z * B.y;
        C.y = A.z * B.x - A.x * B.z;
        C.z = A.x * B.y - A.y * B.x;

        return C;
    }
}
