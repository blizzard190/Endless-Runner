using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour {

    [SerializeField]
    private float moveSpeed;
    public Transform Under;
    private Rigidbody2D myRigidBody;

    private void Start()
    {
        myRigidBody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        myRigidBody.velocity = new Vector2(moveSpeed,myRigidBody.velocity.y);
        if(myRigidBody.velocity.y < 0.5 && myRigidBody.velocity.y > -0.5)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                
                myRigidBody.velocity = new Vector2(moveSpeed, 4);
                StartCoroutine("Jump");
            }
        }
    }

    private IEnumerator Jump()
    {
        float jumpHeight = 4;
        float maxHeight = 8 + myRigidBody.transform.position.y;
        while(Input.GetKey(KeyCode.Space)&& myRigidBody.transform.position.y < maxHeight)
        {
            myRigidBody.velocity = new Vector2(moveSpeed, jumpHeight);
            jumpHeight -= 0.05f;
            yield return null;
        }
        
    }
}
