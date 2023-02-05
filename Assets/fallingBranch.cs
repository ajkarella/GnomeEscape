using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallingBranch : MonoBehaviour
{
    public GameObject parentbranch;

    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Player")
        {
            Invoke("fallBranch", 1f);
        }
    }

    void fallBranch()
    {
        parentbranch = gameObject.transform.parent.gameObject;
        parentbranch.GetComponent<Rigidbody2D>().gravityScale = 2;
        parentbranch.layer = LayerMask.NameToLayer("triggers");
    }
}
