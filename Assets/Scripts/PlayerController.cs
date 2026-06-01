using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;

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
        moveDir = new Vector3(input.Get<Vector2>().x, 0, input.Get<Vector2>().y);
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
            rb.AddForce(moveDir * moveSpeed * 60f, ForceMode.Force);
        }
    }
}
