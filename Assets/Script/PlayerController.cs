using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerrb;
    public int upforce = 100;
    private bool isOnGround = true; // on ground
    public float gravityoffset = 3f;
    public bool gameover = false;
    public bool alive = true;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start)");
        playerrb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityoffset; //Physics.gravity = Physics.gravity * gravityoffset; 

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
        if (collision.gameObject.CompareTag("ground"))
        {
            isOnGround = true; // on ground
            alive = true;
        }
        else if (collision.gameObject.CompareTag("ob"))
        {
            gameover = true;
            alive = false;

            Debug.Log("Game over)");
        }

    }


}