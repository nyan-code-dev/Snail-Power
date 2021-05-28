using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    [SerializeField] private Camera cam;

    private Vector3 startPosition;
    private float parallaxFactor;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
        float distanceFromSubject = transform.position.z - Player.instance.transform.position.z;
        float clippingPlane = cam.transform.position.z + (distanceFromSubject > 0 ? cam.farClipPlane : cam.nearClipPlane);
        parallaxFactor = (distanceFromSubject > 0 ? 1 : -1) * Mathf.Abs(distanceFromSubject / clippingPlane);
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 travel = cam.transform.position - startPosition;
        transform.position = startPosition + (Vector3)travel * parallaxFactor;
    }
}
