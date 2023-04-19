using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerTeleport : MonoBehaviour
{
    private SpriteRenderer renderer;
    public float teleportTime = 1;
    public float teleportTimeLeft;

    private void Start()
    {
        renderer = GetComponent<SpriteRenderer>();
        teleportTimeLeft = teleportTime;
    }


    private void Update()
    {
        renderer.color = new Color(1, 1, 1, teleportTimeLeft);
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (!other.CompareTag("Teleporter")) return;

        teleportTimeLeft -= Time.deltaTime;
        if (teleportTimeLeft <= 0)
        {
            SceneManager.LoadScene(0);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (!other.CompareTag("Teleporter")) return;
        
        teleportTimeLeft = teleportTime;
    }
}
