using Unity.VisualScripting;
using UnityEngine;

public class CameraFollow : MonoBehaviour {
    public Transform target;
    public float speed = 5f;
    public Vector3 offset;

    private void LateUpdate()
    {
        Vector3 desiredPosition = target.position + offset;
        transform.position = Vector3.Lerp(
            transform.position,
            desiredPosition,
            speed * Time.deltaTime

        );
    }

}
