using UnityEngine;
using System.Collections;

public class palyAnimationrScript : MonoBehaviour {

    public Animation anim;
    public void attack()
    {
        GetComponent<Animation>().Play("Trial02");
        Debug.Log("Exploding");
        
    }

    public void putBack()
    {
        GetComponent<Animation>().Play("Assembling back");
        anim["Assembling back"].speed = 0.05f;
        Debug.Log("Assembling back");

    }

    public void changeColor()
    {
        GetComponent<Animation>().Play("colorChange");
        Debug.Log("changing color");
    }
}
