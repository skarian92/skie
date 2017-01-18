using UnityEngine;
using System.Collections;

public class changeScene : MonoBehaviour {

	public void sceneChange(string sceneName)
	{
		Application.LoadLevel (sceneName);
	}

}
