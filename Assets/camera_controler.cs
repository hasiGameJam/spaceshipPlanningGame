﻿using UnityEngine;
using System.Collections;

public class camera_controler : MonoBehaviour {
    float pos = 7;

    void Update () {
        if (pos < 8 && Input.GetAxis("Vertical") > 0
            || pos > 2 && Input.GetAxis("Vertical") < 0)
        {
            pos += Input.GetAxis("Vertical") * 12 * Time.deltaTime;
            transform.position = new Vector3(
                transform.position.x, 
                pos,
                transform.position.z
            );

            transform.LookAt(GameObject.Find("shipBody").transform);
        }
    }
}