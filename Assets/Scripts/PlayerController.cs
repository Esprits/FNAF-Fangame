using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;

    [Header("References")]
    public Transform orientation;

    Rigidbody rb;

    Vector3 moveDir;

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
        moveDir = orientation.forward * input.Get<Vector2>().y + orientation.right * input.Get<Vector2>().x;
    }

    void OnFlashlight(InputValue input)
    {
        Debug.Log(input.isPressed);
        // TODO Toggle the flashlight
    }

    void MovePlayer()
    {
        if (moveDir != Vector3.zero)
        {
            rb.AddForce(moveDir.normalized * moveSpeed * 60f, ForceMode.Force);
        }
    }
}
