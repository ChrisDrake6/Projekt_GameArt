using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float speed;

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            transform.Rotate(new Vector3(0, Input.GetAxis("Mouse X") * speed, 0));
        }
    }
}
