using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer renderer;
    Rigidbody rigidbody;
    [SerializeField] float timeToWait = 3;
    float timer;
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();

        renderer.enabled = false;

        rigidbody = GetComponent<Rigidbody>();

        rigidbody.useGravity = false;
    }

    void Update()
    {
        timer = Time.time;

        if (timer > timeToWait)
        {
            renderer.enabled = true;
            rigidbody.useGravity = true;
        }
    }
}
