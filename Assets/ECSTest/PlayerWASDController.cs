using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWASDController : MonoBehaviour
{

    Rigidbody2D myrigidbody;
    int groundlayermask;
    float timeSinceLastJump;
    public float jumpPower = 1000;
    public float boosterPower = 30;
    // Start is called before the first frame update
    void Start()
    {
        myrigidbody = GetComponent<Rigidbody2D>();
        groundlayermask = LayerMask.GetMask("ForegroundCollidingTile");
    }

    // Update is called once per frame
    void Update()
    {
        bool touchingGround = GetComponent<CircleCollider2D>().IsTouchingLayers(groundlayermask);//16 == foregroundTiles
        Vector2 mov = Vector2.zero;
        if (touchingGround)
        {
            if (Input.GetKey(KeyCode.A))
                mov += Vector2.left;
            if (Input.GetKey(KeyCode.D))
                mov += Vector2.right;

        }



        if (mov == Vector2.zero && touchingGround)
            myrigidbody.velocity *= 0.95f;

        timeSinceLastJump += Time.deltaTime;

        if (Input.GetKey(KeyCode.Space) && touchingGround && timeSinceLastJump > 0.3f)//jump
        {
            mov += Vector2.up * jumpPower;
            timeSinceLastJump = 0;
        }
        else if (Input.GetKey(KeyCode.Space) && timeSinceLastJump > 0.3f)
        {
            myrigidbody.AddForce(Vector2.up * Time.deltaTime * boosterPower, ForceMode2D.Impulse);
        }

        else if (Input.GetKey(KeyCode.S) && timeSinceLastJump > 0.3f)
        {
            myrigidbody.AddForce(Vector2.down * Time.deltaTime * boosterPower, ForceMode2D.Impulse);
        }


        myrigidbody.AddForce(mov * Time.deltaTime * 30, ForceMode2D.Impulse);

    }

    
    void FixedUpdate()
    {
    }
}
