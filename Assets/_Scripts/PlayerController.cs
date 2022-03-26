using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _speed;
    
    private Rigidbody _rb;
    private bool _isMoving = false; // Todo ileride kullanılacak
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow) || MobileInput.Instance.swipeLeft)
        {
            _rb.velocity = Vector3.left * _speed * Time.deltaTime;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow) || MobileInput.Instance.swipeRight)
        {
            _rb.velocity = Vector3.right * _speed * Time.deltaTime;
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow) || MobileInput.Instance.swipeUp)
        {
            _rb.velocity = Vector3.forward * _speed * Time.deltaTime;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) || MobileInput.Instance.swipeDown)
        {
            _rb.velocity = -Vector3.forward * _speed * Time.deltaTime;
        }
        
    }
}
