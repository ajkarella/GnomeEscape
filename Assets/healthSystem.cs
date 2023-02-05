using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TarodevController;

public class healthSystem : MonoBehaviour
{
    public int health;
    public GameObject player;
    public float airtime; 
    public float airtimeGrounded;

    void FixedUpdate()
    {
        if (health <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            health = 5;
        }
    }

    
}
