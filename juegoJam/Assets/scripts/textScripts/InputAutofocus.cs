using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InputAutofocus : MonoBehaviour
{
	public TMP_InputField	startScreenInput;
    
	public void clearInput()
	{
		startScreenInput.text = "";
	}

    public void autoFocus()
	{
		startScreenInput.ActivateInputField();
	}
	
	void Start()
    {
		autoFocus();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
