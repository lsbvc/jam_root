using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class InputIntro : MonoBehaviour
{
	public TMP_InputField InputField;
	public AudioSource audio1;

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
		audio1.Play();
		autoFocus();
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKey("escape"))
       {
	       Debug.Log("exit");
	      Application.Quit();
       }
    }
    public void GetInputText (string InputText)
    {
	    Debug.Log(InputText);
	    if (InputText == "start")
		    SceneManager.LoadScene("SampleScene");
	    if (InputText == "exit")
	    {
		    Debug.Log("exit");
		    Application.Quit();
	    }
//	if InputText == start; next scene
//	else if InputText == exit; exit.

    }

}
