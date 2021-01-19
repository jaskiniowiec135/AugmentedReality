using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuScript : MonoBehaviour
{
	public void GoToMainMenu()
	{
		Application.LoadLevel("MainMenu");
	}

	public void GoToARCamera()
	{
		Application.LoadLevel("0");
	}

	public void ExitApplication()
	{
		Application.Quit();
	}
	public void GoToAuthors()
	{
		Application.LoadLevel("Authors");
	}
	public void GoToSecurityList()
	{
		Application.LoadLevel("Security");
	}
}
