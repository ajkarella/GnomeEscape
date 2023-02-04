using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TarodevController;

public class Doublejump : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Player")
        {
            GameObject.Find("Player").GetComponent<PlayerController>().canDoublejump = true;
            Destroy(gameObject);
        }
    }
}
