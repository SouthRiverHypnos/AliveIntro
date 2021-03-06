using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RansController : MonoBehaviour
{
        public Animator animator;

        public float speed = 4.0f;

        Rigidbody2D rigidbody2d;
        float horizontal = 0;
        float vertical = 0;
 
        void Start()
        {
            rigidbody2d = GetComponent<Rigidbody2D>();
            animator = GetComponent<Animator>();
        }

        void Update()
        {
            horizontal = Input.GetAxis("Horizontal");
            vertical = Input.GetAxis("Vertical");
            Vector2 move = new Vector2(horizontal, vertical);


            animator.SetFloat("MoveX", move.x);


    }

    void FixedUpdate()
        {
            Vector2 position = rigidbody2d.position;
            position.x = position.x + speed * horizontal * Time.deltaTime;
            position.y = position.y + speed * vertical * Time.deltaTime;

            rigidbody2d.MovePosition(position);
        }

}
