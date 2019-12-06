﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlaneScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    public float smooth = 2.0F;
    public float tiltAngle = 20.0F;
    void Update()
    {
        float tiltAroundZ = Input.GetAxis("Horizontal") * -tiltAngle;
        float tiltAroundX = Input.GetAxis("Vertical") * -tiltAngle;
        Quaternion target = Quaternion.Euler(tiltAroundX, 0, tiltAroundZ);
        transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * smooth);


    }
}
