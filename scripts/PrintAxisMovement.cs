using UnityEngine;

public class PrintAxisMovement : MonoBehaviour
{
    public float speed;

    private void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
            Debug.Log("Flecha izquierda: " + speed * Input.GetAxis("Horizontal"));
        
        if (Input.GetKey(KeyCode.RightArrow))
            Debug.Log("Flecha derecha: " + speed * Input.GetAxis("Horizontal"));
        
        if (Input.GetKey(KeyCode.UpArrow))
            Debug.Log("Flecha arriba: " + speed * Input.GetAxis("Vertical"));
        
        if (Input.GetKey(KeyCode.DownArrow))
            Debug.Log("Flecha abajo: " + speed * Input.GetAxis("Vertical"));
    }
}
