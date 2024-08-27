using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControls : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float sensitivity;
    [SerializeField] Camera playerCamera;
    private Vector2 moveDirection = Vector2.zero;
    private Vector2 lookingDirection = Vector2.zero;
	private float cameraPitch = 0.0f;

    private void Update(){
        MoveCharacter(moveDirection);
        LookAround(lookingDirection);
    }

	public void KeyboardMovementInput(InputAction.CallbackContext context){
        moveDirection = context.ReadValue<Vector2>();
	}

    public void MouseLookInput(InputAction.CallbackContext context){
		lookingDirection = context.ReadValue<Vector2>();
	}

    private void MoveCharacter(Vector2 input) {
        transform.position += (transform.forward * input.y + transform.right * input.x) * speed * Time.deltaTime;
    }

    private void LookAround(Vector2 input){
        input *= Time.smoothDeltaTime * sensitivity;
        
        cameraPitch -= input.y; 
        cameraPitch = Mathf.Clamp(cameraPitch, -90f, 90f);
        playerCamera.transform.localEulerAngles = Vector3.right * cameraPitch;
        transform.Rotate(Vector3.up * input.x);
    }

}
