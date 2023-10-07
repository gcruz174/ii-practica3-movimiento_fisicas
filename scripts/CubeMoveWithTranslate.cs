using UnityEngine;

public class CubeMoveWithTranslate : MonoBehaviour
{
    public float speed;

    private void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(horizontal, vertical, 0f);
        transform.Translate(movement * (speed * Time.deltaTime));
    }
}
