using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float timeToWait = 3f;
    MeshRenderer obstacleRenderer;
    Rigidbody obstacleRigidbody;

    void Start()
    {
        obstacleRenderer = GetComponent<MeshRenderer>();
        obstacleRigidbody = GetComponent<Rigidbody>();

        obstacleRenderer.enabled = false;
        obstacleRigidbody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        var timeElapsed = Time.time;

        if (timeElapsed > timeToWait) {
            obstacleRenderer.enabled = true;
            obstacleRigidbody.useGravity = true;
        }
    }
}
