using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerCam : MonoBehaviour
{
    public float sensX;
    public float sensY;

    [Header("References")]
    public Transform orientation;

    float rotX;
    float rotY;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        transform.rotation = Quaternion.Euler(rotX, rotY, 0);
        orientation.rotation = Quaternion.Euler(0, rotY, 0);
    }

    void OnLook(InputValue input)
    {
        float inputX = input.Get<Vector2>().x * Time.deltaTime * sensX;
        float inputY = input.Get<Vector2>().y * Time.deltaTime * sensY;

        rotY += inputX;

        rotX -= inputY;
        rotX = Mathf.Clamp(rotX, -90f, 90f);
    }
}
