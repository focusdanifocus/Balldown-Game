using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rorateObject : MonoBehaviour
{
    Vector3 rotation = new Vector3(0,1,0);
    public float speedRotation;


    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Rotate(rotation * speedRotation * Time.deltaTime);
    }
}
