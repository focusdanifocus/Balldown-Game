using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationItems : MonoBehaviour
{
    Vector3 rotationItem = new Vector3(0,45,0);
    

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotationItem * Time.deltaTime);
    }
}
