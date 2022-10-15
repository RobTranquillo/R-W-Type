using System;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerController : MonoBehaviour
{
    public GameObject playerCharacter;
    public float verticalSpeed = 1f;
    public float horizontalSpeed = 1f;

    private Vector2 flyDirection = Vector2.zero;
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
        if (flyDirection == Vector2.zero)
            return;
        transform.position = transform.position + new Vector3(flyDirection.x, flyDirection.y, 0);
    }

    private void ShipVerticalZero(InputAction.CallbackContext obj)
    {
        flyDirection.y = 0;
    }
    private void ShipHorizontalZero(InputAction.CallbackContext obj)
    {
        flyDirection.x = 0;
    }

    #region - Controller Functions -
    public void ShipUp(InputAction.CallbackContext context)
    {
        flyDirection = new Vector2(flyDirection.x, 1 * verticalSpeed);
    }

    public void ShipDown(InputAction.CallbackContext context)
    {
        flyDirection = new Vector2(flyDirection.x, -1 * verticalSpeed);
    }
    public void ShipAccelerate(InputAction.CallbackContext context)
    {
        flyDirection = new Vector2(1 * verticalSpeed, flyDirection.y);
    }
    public void ShipThrottle(InputAction.CallbackContext context)
    {
        flyDirection = new Vector2(-1 * verticalSpeed, flyDirection.y);
    }
    #endregion - Controller Functions -
}
