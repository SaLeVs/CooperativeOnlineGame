using System;
using UnityEngine;

public class TestInputs : MonoBehaviour
{
    [SerializeField] private InputReader inputReader;

    private void OnEnable()
    {
        inputReader.OnMoveEvent += InputReader_OnMoveEvent;
        inputReader.OnShootEvent += InputReader_OnShootEvent;
        inputReader.OnDashEvent += InputReader_OnDashEvent;
        inputReader.OnJumpEvent += InputReader_OnJumpEvent;
    }

    private void InputReader_OnMoveEvent(Vector2 movement)
    {
        Debug.Log($"Input - Move: {movement}");
    }
    
    private void InputReader_OnShootEvent(bool isShooting)
    {
        Debug.Log($"Input - Shooting: {isShooting}");
    }
    
    private void InputReader_OnDashEvent(bool isDashing)
    {
        Debug.Log($"Input - Dashing: {isDashing}");
    }
    
    private void InputReader_OnJumpEvent(bool isJumping)
    {
        Debug.Log($"Input - Jumping: {isJumping}");
    }

    private void OnDisable()
    {
        inputReader.OnMoveEvent -= InputReader_OnMoveEvent;
        inputReader.OnShootEvent -= InputReader_OnShootEvent;
        inputReader.OnDashEvent -= InputReader_OnDashEvent;
        inputReader.OnJumpEvent -= InputReader_OnJumpEvent;
    }
}
