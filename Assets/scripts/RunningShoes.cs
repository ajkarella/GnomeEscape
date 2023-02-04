using System.Collections;
using System.Collections.Generic;
using TarodevController;
using UnityEngine;

public class RunningShoes : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Player")
        {
            GameObject.Find("Player").GetComponent<PlayerController>().canSprint = true;
            Destroy(gameObject);
        }
        else
        {
            Debug.Log("colliding at least");
        }
    }
}
