using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    public Transform ball;
    public float sSpeed = 10.0f;
    public Vector3 cameraOffset;
    public Transform lookTarget;

    void FixedUpdate(){
        Vector3 dPos = ball.position + cameraOffset;
        Vector3 sPos = Vector3.Lerp(transform.position, dPos , sSpeed * Time.deltaTime);
        transform.position = sPos;
    }


}
