using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private Transform _targetTransform;
    [SerializeField] private Vector3 _cameraOffset;
    [SerializeField] private float _lerpValue;
    
    void LateUpdate()
    {
        Vector3 desiredPosition = _targetTransform.position + _cameraOffset;
        transform.position = Vector3.Lerp(transform.position, desiredPosition, _lerpValue);
        
    }
}
