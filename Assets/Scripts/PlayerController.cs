using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    Rigidbody rb;

    Vector2 moveDirection;
    Vector2 lookDirection;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {

    }

    void OnMove(InputValue input)
    {
        moveDirection = input.Get<Vector2>();
        // TODO Make the player move
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
}
