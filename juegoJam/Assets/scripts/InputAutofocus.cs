using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InputAutofocus : MonoBehaviour
{
	public TMP_InputField InputField;
    
	public void clearInput()
	{
		InputField.text = "";
		autoFocus();
	}

    public void autoFocus()
	{
		InputField.ActivateInputField();
	}
	
	void Start()
    {
		autoFocus();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void GetInputText (string InputText)
    {
	    Debug.Log(InputText);
//	Add functions to check and kill virus.

    }

}
