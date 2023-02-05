using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TarodevController;


public class SpiderWeb : MonoBehaviour
{

    void OnTriggerStay2D(Collider2D target)
    {
        if (target.tag == "Player")
        {
            GameObject.Find("Player").GetComponent<PlayerController>()._moveClamp = 3;
            GameObject.Find("Player").GetComponent<PlayerController>().isWebbed = true;
        }
    }
    void OnTriggerExit2D(Collider2D target)
    {
        if (target.tag == "Player")
        {
            GameObject.Find("Player").GetComponent<PlayerController>()._moveClamp = 13;
            GameObject.Find("Player").GetComponent<PlayerController>().isWebbed = false;
        }
    }
}
