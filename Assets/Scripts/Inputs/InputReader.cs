using System;
using UnityEngine;
using UnityEngine.InputSystem;
using static PlayerControls;

[CreateAssetMenu(fileName = "InputReader", menuName = "ScriptableObjects/InputReader", order = 1)]
public class InputReader : ScriptableObject, IPlayerActions 
{
        
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
        
    }

    public void OnShoot(InputAction.CallbackContext context)
    {
        
    }

    public void OnDash(InputAction.CallbackContext context)
    {
        
    }

    public void OnJump(InputAction.CallbackContext context)
    {
        
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
