using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    Vector3 camerapos;
    void Update()
    {
        camerapos = new Vector3(GameObject.FindWithTag("Player").transform.position.x, GameObject.FindWithTag("Player").transform.position.y, -20.0f);
        transform.position = camerapos;
    }
}
