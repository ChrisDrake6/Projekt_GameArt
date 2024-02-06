using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Billboard : MonoBehaviour
{
    public float offset;
    public Transform target;

    void Update()
    {
        Vector3 newPosition = Camera.main.WorldToScreenPoint(new Vector3(target.position.x, target.position.y, target.position.z));
        newPosition.y += offset;
        transform.position = newPosition;
    }
}