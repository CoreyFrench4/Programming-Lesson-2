﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0f, 0f, .1f);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0f, 0f, -.1f);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0f, 5f, 0f);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0f, -5f, 0f);
        }
    }
}
