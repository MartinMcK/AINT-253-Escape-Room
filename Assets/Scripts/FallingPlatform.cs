﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingPlatform : MonoBehaviour {

    bool isFalling = false;
    float downSpeed = 0;

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.name == "player")
            isFalling = true;
    }

    private void Update()
    {
        if (isFalling)
        {
            downSpeed += Time.deltaTime/5;
            transform.position = new Vector3(transform.position.x,
                transform.position.y - downSpeed,
                transform.position.z);
        }
    }




}
