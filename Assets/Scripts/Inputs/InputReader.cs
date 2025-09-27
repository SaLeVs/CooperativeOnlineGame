using System;
using UnityEngine;
using UnityEngine.InputSystem;
using static PlayerControls;

[CreateAssetMenu(fileName = "InputReader", menuName = "ScriptableObjects/InputReader", order = 1)]
public class InputReader : ScriptableObject, IPlayerActions 
{
    public event Action<bool> OnShootEvent;
    public event Action<Vector2> OnMoveEvent;
    public event Action<bool> OnJumpEvent;  
    public event Action<bool> OnDashEvent;
    
    private PlayerControls playerControls;
    
    private void OnEnable()
    {
        if (playerControls == null)
        {
            playerControls = new PlayerControls();
            playerControls.Player.SetCallbacks(this);
        }
        
        playerControls.Player.Enable();
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        OnMoveEvent?.Invoke(context.ReadValue<Vector2>());
    }

    public void OnShoot(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            OnShootEvent?.Invoke(true);
        }
        else if (context.canceled)
        {
            OnShootEvent?.Invoke(false);
        }
    }

    public void OnDash(InputAction.CallbackContext context)
    {
        if(context.started)
        {
            OnDashEvent?.Invoke(true);
        }
        else if (context.canceled)
        {
            OnDashEvent?.Invoke(false);
        }
    }

    public void OnJump(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            OnJumpEvent?.Invoke(true);
        }
        else if (context.canceled)
        {
            OnJumpEvent?.Invoke(false); 
        }
    }

    private void OnDisable()
    {
        if (playerControls != null)
        {
            playerControls.Player.Disable();
            playerControls.Player.SetCallbacks(null);
        }
    }
}
