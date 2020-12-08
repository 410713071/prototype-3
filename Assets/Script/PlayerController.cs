using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerrb;
    public int upforce = 100;
    private bool isOnGround = true; // on ground

    // Start is called before the first frame update
    void Start()
    {
        playerrb = GetComponent<Rigidbody>();
        playerrb.AddForce(Vector3.up * upforce);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            playerrb.AddForce(Vector3.up * upforce, ForceMode.Impulse);
            isOnGround = false; // not on ground
        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        isOnGround = true; // on ground
    }
}