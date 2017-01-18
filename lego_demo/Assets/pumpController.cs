using UnityEngine;
using System.Collections;

public class pumpController : MonoBehaviour {

	public palyAnimationrScript p;

	void Start () {
	
	}
	

	void Update () {
	
	}

	public void explode()
	{
		Debug.Log ("Explode Function called");
		p.attack ();

	}

	public void assembleBack()
	{
		Debug.Log ("Assemble back function called");
		p.putBack ();
	}

}
