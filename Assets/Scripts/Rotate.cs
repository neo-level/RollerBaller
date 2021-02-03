using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    private Vector3 _rotation = new Vector3(15, 30, 45);

    private void Update()
    {
        transform.Rotate(_rotation * Time.deltaTime);
    }
}