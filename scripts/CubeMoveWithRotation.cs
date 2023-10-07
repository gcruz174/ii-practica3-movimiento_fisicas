using UnityEngine;

public class CubeMoveWithRotation : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;

    private void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(0f, 0f, vertical);
        transform.Translate(movement * (speed * Time.deltaTime));
        transform.Rotate(Vector3.up, rotationSpeed * horizontal * Time.deltaTime);
        Debug.DrawRay(transform.position, transform.forward, Color.green);
    }
}
