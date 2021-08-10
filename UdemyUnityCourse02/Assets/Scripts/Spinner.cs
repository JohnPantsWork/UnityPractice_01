using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float rotateX = 0;
    [SerializeField] float rotateY = 0;
    [SerializeField] float rotateZ = 0;
    void Start()
    {

    }

    void Update()
    {
        transform.Rotate(rotateX, rotateY, rotateZ);
    }
}
