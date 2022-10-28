using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : Collectible
{
    MeshRenderer playerMesh;
    MeshRenderer mesh;

    // Start is called before the first frame update
    void Start()
    {
        playerMesh = GameObject.FindGameObjectWithTag("Player").GetComponent<MeshRenderer>();
        mesh = GetComponent<MeshRenderer>();
        mesh.material.color = Color.green;
    }

    private void OnTriggerEnter(Collider other)
    {
        playerMesh.material.color = Color.green;
        Destroy(gameObject);
    }
}
