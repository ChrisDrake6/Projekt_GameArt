using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Billboard : MonoBehaviour
{
    private Transform camTransform;
    private Quaternion originalRotation;

    void Start()
    {
        camTransform = Camera.main.transform;
        originalRotation = transform.localRotation;
    }

    void Update()
    {
        transform.rotation = camTransform.rotation * originalRotation;
    }
}