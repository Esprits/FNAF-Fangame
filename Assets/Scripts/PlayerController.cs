using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;

    Rigidbody rb;

    Vector3 moveDirection;
    Vector2 lookDirection;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }

    void Update()
    {

    }

    void FixedUpdate()
    {
        MovePlayer();
    }

    void OnMove(InputValue input)
    {
        moveDirection = new Vector3(input.Get<Vector2>().x, 0, input.Get<Vector2>().y);
    }

    void OnLook(InputValue input)
    {
        lookDirection = input.Get<Vector2>();
        // TODO Make the player look around
    }

    void OnFlashlight(InputValue input)
    {
        Debug.Log(input.isPressed);
        // TODO Toggle the flashlight
    }

    void MovePlayer()
    {
        if (moveDirection != Vector3.zero)
        {
            rb.AddForce(moveDirection * moveSpeed * 60f, ForceMode.Force);
        }
    }
}
