using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D playerRigidBody;
    private float movementHorizontal;
    private float movementVertical;
    public float horizontalSpeed;
    public float verticalSpeed;
    public float drag;
    // Start is called before the first frame update
    void Start()
    {
        playerRigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        moveHorizontal();
        moveVertical();

        dragPlayer();
    }

    private void moveHorizontal()
    {
        movementHorizontal = Input.GetAxisRaw("Horizontal");

        playerRigidBody.AddForce(new Vector2(movementHorizontal * Time.deltaTime * horizontalSpeed, 0));
    }

    private void moveVertical()
    {
        movementVertical = Input.GetAxisRaw("Vertical");

        playerRigidBody.AddForce(new Vector2(0, movementVertical * Time.deltaTime * verticalSpeed));
    }

    private void dragPlayer()
    {
        playerRigidBody.velocity = new Vector2(playerRigidBody.velocity.x * (1 / drag), playerRigidBody.velocity.y * (1/drag));
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }
}
