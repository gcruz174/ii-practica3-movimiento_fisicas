using UnityEngine;

public class CubeTranslate : MonoBehaviour
{
    public Vector3 moveDirection;
    public float speed = 1;

    private void Update()
    {
        transform.Translate(moveDirection * speed);
    }
}
