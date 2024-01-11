using UnityEngine;

public class CameraTarget : MonoBehaviour
{
    [SerializeField] float rotationSpeed = 100f;
    [SerializeField] float mouseRotationSpeed = 600f;
    [Tooltip("Invert the direction the camera moves when using Q or E")]
    [SerializeField] private bool invertKeyDirection = false;

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            transform.Rotate(Vector3.up, Input.GetAxis("Mouse X") * mouseRotationSpeed * Time.deltaTime);
            return;
        }
        
        if(Input.GetKey(KeyCode.Q) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.up, invertKeyDirection ? -1f : 1f * rotationSpeed * Time.deltaTime);
        }
        else if(Input.GetKey(KeyCode.E) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.up, invertKeyDirection ? 1f : -1f * rotationSpeed * Time.deltaTime);
        }
    }
}
