using UnityEngine;

public class CubeMoveTowardsSphere : MonoBehaviour
{
    public float speed;
    public Transform sphere;

    private void Update()
    {
        Vector3 movement = (sphere.position - transform.position).normalized;
        transform.Translate(movement * (speed * Time.deltaTime), Space.World);
        transform.LookAt(sphere);
    }
}
