using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControls : MonoBehaviour
{
    public InputActionReference moveAction;
    [SerializeField] float speed = 10f;
    [SerializeField] float sensitivity = 2f;
    [SerializeField] Camera playerCamera;
    private Vector2 moveDirection = Vector2.zero;
    private Vector2 lookingDirection = Vector2.zero;
	private float cameraPitch = 0.0f;
	private Vector2 currentMouseDelta = Vector2.zero;
	private Vector2 currentMouseDeltaVelocity = Vector2.zero;

	private void Start(){
        //moveAction.action.ApplyBindingOverride(new InputBinding { overrideProcessors = "scale(factor=10)" });
    }


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
        if (!playerCamera) {
            Debug.Log("No camera!");
            return;
        }
        input *= Time.smoothDeltaTime * sensitivity;
        Debug.Log(input);
        cameraPitch -= input.y; 
        cameraPitch = Mathf.Clamp(cameraPitch, -90f, 90f);
        playerCamera.transform.localEulerAngles = Vector3.right * cameraPitch;
        transform.Rotate(Vector3.up * input.x);
    }

}
