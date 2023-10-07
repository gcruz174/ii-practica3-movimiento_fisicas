using UnityEngine;

public class CylinderMove : MonoBehaviour
{
    private Rigidbody _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }
    
    private void Update()
    {
        var horizontal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical");
        var force = new Vector3(horizontal, 0f, vertical);
        _rigidbody.AddForce(force);
    }
}
