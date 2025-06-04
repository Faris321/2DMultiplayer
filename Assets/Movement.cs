using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Movement : MonoBehaviour
{
     public float moveSpeed = 5f;
     private Rigidbody2D rb;
     private Vector2 moveInput;

     void Start()
     {
          rb = GetComponent<Rigidbody2D>();
     }

     void Update()
     {
          moveInput.x = Input.GetKey(KeyCode.D) ? 1 : Input.GetKey(KeyCode.A) ? -1 : 0;
          moveInput.y = Input.GetKey(KeyCode.W) ? 1 : Input.GetKey(KeyCode.S) ? -1 : 0;
          moveInput = moveInput.normalized;
     }

     void FixedUpdate()
     {
          rb.linearVelocity = moveInput * moveSpeed;
     }
}
