﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForwardBackward : MonoBehaviour {

    private bool movesForward = true;

    private float starting_Z_Point;



	// Use this for initialization
	void Start () {
        // scene onafhankelijk
        starting_Z_Point = transform.position.z;
		

    }
	
	// Update is called once per frame
	void Update () {
        Debug.Log("logging Z position:" + transform.position.z);







        if (movesForward)
        {
            transform.Translate(Vector3.forward * Time.deltaTime);
            if(transform.position.z >= starting_Z_Point + 6.0) // max 4"stappen vooruit"
            {
                movesForward = !movesForward;
            }

        }
        else if (!movesForward)
        {
            transform.Translate(Vector3.back * Time.deltaTime);
            if (transform.position.z <= starting_Z_Point)
            {
                movesForward = !movesForward;
            }
        }



	}
}
