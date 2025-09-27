using System;
using UnityEngine;

public class TestInputs : MonoBehaviour
{
    [SerializeField] private InputReader inputReader;

    private void Start()
    {
        inputReader.OnMoveEvent += InputReader_OnMoveEvent;
        inputReader.OnShootEvent += InputReader_OnShootEvent;
        inputReader.OnDashEvent += InputReader_OnDashEvent;
        inputReader.OnJumpEvent += InputReader_OnJumpEvent;
        
        
    }

    private void InputReader_OnMoveEvent(Vector2 movement)
    {
        
    }
    
    private void InputReader_OnShootEvent(bool isShooting)
    {
        
    }
    
    private void InputReader_OnDashEvent(bool isDashing)
    {
        
    }
    
    private void InputReader_OnJumpEvent(bool isJumping)
    {
        
    }
}
