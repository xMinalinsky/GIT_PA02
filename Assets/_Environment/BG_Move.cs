using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BG_Move : MonoBehaviour
{
    void Update()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - 16 * Time.deltaTime);

        if (transform.position.z <= -8)
            transform.position = new Vector3(transform.position.x, transform.position.y, 45);
    }
}
