using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBoost : Collectible
{
    PlayerMovement playerScript;
    MeshRenderer mesh;

    // Start is called before the first frame update
    void Start()
    {
        playerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();
        mesh = GetComponent<MeshRenderer>();
        mesh.material.color = Color.yellow;
    }

    private void OnTriggerEnter(Collider other)
    {
        playerScript.playerSpeed = 15f;
        Destroy(gameObject);
    }
}
