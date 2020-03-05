using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public Transform target;

    public float smoothSpeed = 0.125f;
    public Vector3 offset;
    public Vector3 offset1;
    public Vector3 offset2;

    void Start()
    {
        offset = offset2;
    }

    void FixedUpdate()
    {
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;
        if (WalkScript.facingDirection == true)
        {
             offset = offset2;
        }
        else if (WalkScript.facingDirection == false)
        {
            offset = offset1;
        }
    }
}
