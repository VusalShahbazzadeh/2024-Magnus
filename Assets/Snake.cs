using System;
using DefaultNamespace;
using UnityEngine;

public class Snake : MonoBehaviour
{
    public Segment firstSegment;
    private Vector3 lastMousePosition;

    public void Update()
    {
        var mouseMove = (Input.mousePosition - lastMousePosition).x;
        lastMousePosition = Input.mousePosition;

        firstSegment.transform.Rotate(Vector3.up, mouseMove);

        firstSegment.transform.position += firstSegment.transform.forward * Time.deltaTime;
    }
}