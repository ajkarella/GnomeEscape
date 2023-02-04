using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hurtbox : MonoBehaviour
{
    public GameObject Player;
    public bool isRightSide;
    private bool isKnocked = false;
    private float px;
    private float py;

    private void Update()
    {
        knockBack();
    }

    private void knockBack()
    {
        if (isKnocked)
        {
            if (!isRightSide)
            {
                px = Player.transform.position.x;
                py = Player.transform.position.y;
                Player.transform.position = new Vector3(-.25f + px, .25f + py, 0);
            }
            else
            {
                px = Player.transform.position.x;
                py = Player.transform.position.y;
                Player.transform.position = new Vector3(.25f + px, .25f + py, 0);
            }
        }
    }

    private void cancelKnock()
    {
        isKnocked = false;
    }

    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Player")
        {
            isKnocked = true;
            Invoke("cancelKnock", 0.2f);
        }
    }
}
