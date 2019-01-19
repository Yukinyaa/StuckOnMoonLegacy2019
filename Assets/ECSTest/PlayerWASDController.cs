using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWASDController : MonoBehaviour
{

    Rigidbody2D myrigidbody;
    int groundlayermask;
    float timeSinceLastJump;
    public float jumpPower = 100;
    public float boosterPower = 3;
    // Start is called before the first frame update
    void Start()
    {
        myrigidbody = GetComponent<Rigidbody2D>();
        groundlayermask = LayerMask.GetMask("ForegroundCollidingTile");
    }

    // Update is called once per frame
    void Update()
    {
        bool touchingGround = GetComponent<CapsuleCollider2D>().IsTouchingLayers(groundlayermask);//16 == foregroundTiles
        Vector2 mov = Vector2.zero;
        
        if (Input.GetKey(KeyCode.A))
            mov += Vector2.left;
        if (Input.GetKey(KeyCode.D))
            mov += Vector2.right;
        if (!touchingGround && timeSinceLastJump > 0.3f)
            mov *= boosterPower;



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
            mov += Vector2.up * boosterPower;
        }

        else if (Input.GetKey(KeyCode.S) && timeSinceLastJump > 0.3f)
        {
            mov -= Vector2.up * boosterPower;
        }


        myrigidbody.AddForce(mov * Time.deltaTime * 30, ForceMode2D.Impulse);

    }

    
    void FixedUpdate()
    {
    }
}
