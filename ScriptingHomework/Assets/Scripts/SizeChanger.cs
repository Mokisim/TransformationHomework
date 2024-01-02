using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[RequireComponent(typeof(Transform))]
public class SizeChanger : MonoBehaviour
{
    [SerializeField] private float _changeStep;
    [SerializeField] private Vector3 _endScale;
    [SerializeField] private Vector3 _startScale;

    private Vector3 _targetScale;

    private void Start()
    {
        _targetScale = _endScale;
    }

    private void Update()
    {
        ChangeSize();
    }

    private void ChangeSize()
    {
        transform.localScale = Vector3.MoveTowards(transform.localScale, _targetScale, _changeStep);

        if(transform.localScale == _endScale)
        {
            _targetScale = _startScale;
        }
        else if(transform.localScale == _startScale)
        {
            _targetScale = _endScale;
        }
    }
}
