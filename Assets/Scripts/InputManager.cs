using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
	[SerializeField]
	private InventoryDisplay display;

	public Vector2 moveDirection { get; private set; } = Vector2.zero;
	public Vector2 lookingDirection { get; private set; } = Vector2.zero;

	public void KeyboardMovementInput(InputAction.CallbackContext context) => moveDirection = context.ReadValue<Vector2>();

	public void MouseLookInput(InputAction.CallbackContext context) => lookingDirection = context.ReadValue<Vector2>();

	public void InventoryOpen(InputAction.CallbackContext context) {
		if (context.performed) Debug.Log("Button Pressed");
	}

	public void DropItem(InputAction.CallbackContext context) {
		if (context.performed) display.DropItem(0);
	}
}
