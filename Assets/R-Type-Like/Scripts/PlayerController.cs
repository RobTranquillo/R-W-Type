using System;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerController : MonoBehaviour
{
    public GameObject playerCharacter;
    public float verticalSpeed = 1f;
    public float horizontalSpeed = 1f;

    [Header("Player Screen Boundaries")]
    public float upperLimit = 0;
    public float lowerLimit = 0;
    public float backwardsLimit = 0;
    public float forwardLimit = 0;


    private Vector2 moveDirection = Vector2.zero;
    private InputKeyboard inputKeyboard;
    
    private void OnEnable()
    {
        inputKeyboard.ShipControl.Enable();
    }
    private void OnDisable()
    {
        inputKeyboard.ShipControl.Disable();
    }

    private void Awake()
    {
        inputKeyboard = new InputKeyboard();

        inputKeyboard.ShipControl.ShipUp.started += ShipUp;
        inputKeyboard.ShipControl.ShipUp.canceled += ShipVerticalZero;
        inputKeyboard.ShipControl.ShipDown.started += ShipDown;
        inputKeyboard.ShipControl.ShipDown.canceled += ShipVerticalZero;
        inputKeyboard.ShipControl.ShipAccelerate.started += ShipAccelerate;
        inputKeyboard.ShipControl.ShipAccelerate.canceled += ShipHorizontalZero;
        inputKeyboard.ShipControl.ShipThrottle.started += ShipThrottle;
        inputKeyboard.ShipControl.ShipThrottle.canceled += ShipHorizontalZero;
    }

    private void OnDestroy()
    {
        inputKeyboard.ShipControl.ShipUp.started -= ShipUp;
        inputKeyboard.ShipControl.ShipUp.canceled -= ShipVerticalZero;
        inputKeyboard.ShipControl.ShipDown.started -= ShipDown;
        inputKeyboard.ShipControl.ShipDown.canceled -= ShipVerticalZero;
        inputKeyboard.ShipControl.ShipAccelerate.started -= ShipAccelerate;
        inputKeyboard.ShipControl.ShipAccelerate.canceled -= ShipHorizontalZero;
        inputKeyboard.ShipControl.ShipThrottle.started -= ShipThrottle;
        inputKeyboard.ShipControl.ShipThrottle.canceled -= ShipHorizontalZero;
    }


    private void Update()
    {
        if (moveDirection == Vector2.zero)
            return;
        transform.position = ApplyPlayerBoundaries(transform.position + new Vector3(moveDirection.x, moveDirection.y, 0));
    }

    private Vector3 ApplyPlayerBoundaries(Vector3 pos)
    {
        pos.y = Math.Clamp(pos.y, lowerLimit, upperLimit);
        pos.x = Math.Clamp(pos.x, backwardsLimit, forwardLimit);
        return pos;
    }

    #region - Controller Functions -

    // begin movement
    public void ShipUp(InputAction.CallbackContext context)
    {
        moveDirection = new Vector2(moveDirection.x, 1 * verticalSpeed);
    }

    public void ShipDown(InputAction.CallbackContext context)
    {
        moveDirection = new Vector2(moveDirection.x, -1 * verticalSpeed);
    }
    public void ShipAccelerate(InputAction.CallbackContext context)
    {
        moveDirection = new Vector2(1 * verticalSpeed, moveDirection.y);
    }
    public void ShipThrottle(InputAction.CallbackContext context)
    {
        moveDirection = new Vector2(-1 * verticalSpeed, moveDirection.y);
    }

    // end movement
    private void ShipVerticalZero(InputAction.CallbackContext obj)
    {
        moveDirection.y = 0;
    }
    private void ShipHorizontalZero(InputAction.CallbackContext obj)
    {
        moveDirection.x = 0;
    }
    #endregion - Controller Functions -
}
