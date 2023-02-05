using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spiderMovement : MonoBehaviour
{
    public float speed = 5;
    public bool leftTrigger;
    private bool trackPlayer;
    public GameObject spider;

    // Update is called once per frame
    void Update()
    {
        if (trackPlayer)
        {
            if (leftTrigger)
            {
                spider.transform.position += transform.right * -speed * Time.deltaTime;
            }
            else
            {
                spider.transform.position += transform.right * speed * Time.deltaTime;
            }
        }
    }

    void OnTriggerStay2D(Collider2D target)
    {
        if (target.tag == "Player")
        {
            trackPlayer = true;
        }
    }

    void OnTriggerExit2D(Collider2D target)
    {
        if (target.tag == "Player")
        {
            trackPlayer = false;
        }
    }
}
