using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ReturnGame : MonoBehaviour
{


	public void ReturnTitle()
	{
		SceneManager.LoadScene("Labyrinth");
	}
}