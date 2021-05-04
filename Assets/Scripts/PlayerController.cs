using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private Rigidbody playerRB;
    public float jumpForce = 10.0f;
    public float gravityModifier;
    public bool isOnGround = true;

    public float horizontalinput;
    public float speed = 10.0f;
    private float xRange = 15.0f;

    private GameManager gameManager;

    public bool gameOver = false;


    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody>();

        Physics.gravity *= gravityModifier;


    }

    // Update is called once per frame
    void Update()
    {
        //Keep Player inbounds

        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        horizontalinput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalinput * Time.deltaTime * speed);


        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            playerRB.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;

        }

    }


}


     