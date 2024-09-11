using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floor : MonoBehaviour
{
    private float moveSpeed = -20;
    private float zBound = 150;
    private float zOffset = -300;
    private void Update()
    {
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

        if (transform.position.z >= zBound)
        {
            transform.position += new Vector3(0, 0, zOffset);
        }
    }
}
