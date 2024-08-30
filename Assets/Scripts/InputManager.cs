using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
	[SerializeField]
	private InventoryDisplay display;
	[SerializeField]
	private InventoryDisplay craftingDisplay;

	public Vector2 moveDirection { get; private set; } = Vector2.zero;
	public Vector2 lookingDirection { get; private set; } = Vector2.zero;
	private void Start()
	{
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = false;
	}

	public void KeyboardMovementInput(InputAction.CallbackContext context) => moveDirection = context.ReadValue<Vector2>();

	public void MouseLookInput(InputAction.CallbackContext context)
	{
		if (Cursor.lockState == CursorLockMode.None) lookingDirection = Vector3.zero;
		else lookingDirection = context.ReadValue<Vector2>();
	}

	public void InventoryOpen(InputAction.CallbackContext context) {
		Debug.Log("Yes");
		if (context.performed) { 
			display.gameObject.SetActive(!display.gameObject.activeSelf);
			craftingDisplay.gameObject.SetActive(false);

			if (Cursor.lockState == CursorLockMode.None && !display.gameObject.activeSelf) { 
				Cursor.lockState = CursorLockMode.Locked; 
				Cursor.visible = false;
			} 
			else { 
				Cursor.lockState = CursorLockMode.None;
				Cursor.visible = true;
			}
		}
	}

	public void DropItem(InputAction.CallbackContext context) {
		if (context.performed) display.DropItem(0);
	}
}
