using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    CustomControl playerContols;

    public float leftTouch = 0.0f;
    public float leftMenu = 0.0f;
    public float leftGrip = 0.0f;
    public float leftConnect = 0.0f;
    public float rightTouch = 0.0f;
    public float rightMenu = 0.0f;
    public float rightGrip = 0.0f;
    public float rightConnect = 0.0f;
    public float leftTouchClick = 0.0f;
    public float rightTouchClick = 0.0f;
    
    private void Awake() {
        playerContols = new CustomControl();
    }

    private void OnEnable() {
        playerContols.Enable();
    }

    private void OnDisable() {
        playerContols.Disable();
    }

    void FixedUpdate()
    {
        leftTouch = playerContols.Player.LeftTouch.ReadValue<float>();
        leftMenu = playerContols.Player.LeftMenu.ReadValue<float>();
        leftGrip = playerContols.Player.LeftGrip.ReadValue<float>();
        leftConnect = playerContols.Player.LeftConnect.ReadValue<float>();
        rightTouch =    playerContols.Player.RightTouch.ReadValue<float>();
        rightMenu =     playerContols.Player.RightMenu.ReadValue<float>();
        rightGrip =     playerContols.Player.RightGrip.ReadValue<float>();
        rightConnect =  playerContols.Player.RightConnect.ReadValue<float>();
        leftTouchClick = playerContols.Player.LeftTouchClick.ReadValue<float>();
        rightTouchClick = playerContols.Player.RightTouchClick.ReadValue<float>();
    }
}
