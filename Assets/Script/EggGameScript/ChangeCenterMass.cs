﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCenterMass : MonoBehaviour {

    public Transform centerMass;
    Rigidbody _rigidbody;
    public Transform forcePosition;

    public void Start() {
        _rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update() {
        _rigidbody.centerOfMass = centerMass.localPosition;
	}

}
