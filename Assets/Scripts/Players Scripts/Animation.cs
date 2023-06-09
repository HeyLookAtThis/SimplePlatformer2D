using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]

public class Animation : MonoBehaviour
{
    private const string Horizontal = "Horizontal";
    private Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        float speed = Math.Abs(Input.GetAxis(Horizontal));
        _animator.SetFloat(ACPriest.Params.Speed, speed);
    }

    private void OnTriggerEnter2D(Collider2D player)
    {
        if (player.TryGetComponent<FinishPoint>(out FinishPoint point))
            _animator.SetTrigger(ACPriest.Params.FinishGame);
    }
}
