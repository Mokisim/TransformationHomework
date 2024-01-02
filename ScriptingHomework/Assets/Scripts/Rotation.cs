using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Transform))]
public class Rotation : MonoBehaviour
{
    [SerializeField]private float _speed;

    private Transform _transform;

    private void Start()
    {
        _transform = GetComponent<Transform>();
    }

    private void Update()
    {
        _transform.Rotate(0f, transform.rotation.y + _speed, 0f);
    }
}
