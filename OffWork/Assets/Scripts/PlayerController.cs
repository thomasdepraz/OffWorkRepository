using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Timeline;
using Cache = Unity.VisualScripting.Cache;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _speed;

    private MouseService _mouseService;
    private Transform _selfTransform;

    void Start()
    {
        _mouseService = new MouseService();
        _selfTransform = transform;
    }

    void Update()
    {
        Move();
    }

    private void Move()
    {
        var direction = _mouseService.GetToMouseDirection(_selfTransform.position);

        var ratio = Math.Clamp(direction.sqrMagnitude, 0, 1);
        transform.position += (UnityEngine.Vector3)direction * Time.deltaTime * _speed * ratio;
    }
}