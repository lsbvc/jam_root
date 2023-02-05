using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InputIntro : MonoBehaviour
{
	public TMP_InputField InputField;
    
	public void clearInput()
	{
		InputField.text = "";
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
//	if InputText == start; next scene
//	else if InputText == exit; exit.

    }

}
