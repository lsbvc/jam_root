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

    public void GetInputText(string InputText)
    {
		// Add functions to check and kill virus.
		if (InputText.StartsWith("rm "))
		{
			InputText = InputText.Substring(3);
			if (EnemyController.currentEnemies.Contains(InputText))
			{
				EnemyController[] enemiesRefs = GameObject.FindObjectsOfType<EnemyController>();
				foreach (EnemyController en in enemiesRefs)
				{
					if (en.name == InputText)
					{
						Destroy(en.gameObject);
						EnemyController.currentEnemies.Remove(InputText);
						break;
					}
				}
			}
			else
			{
				// Fail sound or some kind of bad input feedback.
			}
		}
		else
		{
			// Fail sound or some kind of bad input feedback.
		}
    }
}
