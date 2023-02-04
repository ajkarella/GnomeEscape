using System.Collections;
using System.Collections.Generic;
using TarodevController;
using UnityEngine;

public class Wallgrab : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Player")
        {
            GameObject.Find("Player").GetComponent<PlayerController>().canWallgrab = true;
            Destroy(gameObject);
        }
    }
}
