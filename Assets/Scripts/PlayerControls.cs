using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControls : MonoBehaviour
{
    public InputActionReference moveAction;

    // Start is called before the first frame update
    void Start()
    {
        moveAction.action.ApplyBindingOverride(new InputBinding { overrideProcessors = "scale(factor=10)" });
    }


    // Update is called once per frame
    void Update()
    {

    }

	public void Movement(InputAction.CallbackContext context)
	{
        Vector2 val = context.ReadValue<Vector2>();
        Debug.Log(val);

	}


}
