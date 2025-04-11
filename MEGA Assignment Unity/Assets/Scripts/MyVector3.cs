using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyVector3 
{
    public float x, y, z;

    public MyVector3(float x, float y, float z) 
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }

    public static MyVector3 AddVector(MyVector3 a, MyVector3 b) 
    {
        MyVector3 rv = new MyVector3(0, 0, 0);
        
        rv.x = a.x + b.x;
        rv.y = a.y + b.y;
        rv.z = a.z + b.z;

        return rv;
    }

    public static MyVector3 SubtractVector(MyVector3 a, MyVector3 b) 
    {
        MyVector3 rv = new MyVector3(0,0,0);

        rv.x = a.x - b.x;
        rv.y = a.y - b.y;
        rv.z = a.z - b.z;

        return rv;
    }

    public float Length() 
    {
        float rv = 0.0f;

        rv = Mathf.Sqrt(x*x + y*y + z*z);

        return rv;
    }

    public Vector3 ToUnityVector() 
    {
        Vector3 rv = new Vector3(x, y, z);

        return rv;
    }
}
