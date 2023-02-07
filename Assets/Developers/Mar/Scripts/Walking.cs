using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walking : MonoBehaviour
{
    private Vector3 _inputVector;
    [SerializeField] private float _moveSpeed, _rotateSpeed;
    [SerializeField] private GameObject _model;
    [SerializeField] private bool _turnModel;

    private void Update()
    {
        _inputVector = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));

        transform.position += _inputVector.normalized * (_moveSpeed * Time.deltaTime);
    }
}
