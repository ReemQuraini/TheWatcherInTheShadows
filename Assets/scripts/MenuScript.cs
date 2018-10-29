using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour {

	public Canvas quitMenu;
	public Button newGame;
	public Button cont;
	public Button Options;
	public Button Quit;

	public Button Yes;
	public Button No;

	void Start()
	{
		quitMenu = quitMenu.GetComponent<Canvas> ();
		quitMenu.enabled = false;
		Yes.enabled = false;
		No.enabled = false;
	}

	public void ExitPress()
	{
		quitMenu.enabled = true;
		Yes.enabled = false;
		No.enabled = false;
	}

	public void NoPress()
	{
		quitMenu.enabled = false;
		Yes.enabled = false;
		No.enabled = false;

	}

	private void StartLevel()
	{
		SceneManager.LoadScene ("scene_0_0");
	}

	public void ExitGame()
	{
		Application.Quit ();
	}

	public void Overwite()
	{

		StartLevel ();
	}
}
