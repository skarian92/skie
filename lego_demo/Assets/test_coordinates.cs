using UnityEngine;
using System.Collections;

public class test_coordinates : MonoBehaviour {
    public GameObject ARcam;
    private float n1;
    private float n2;
    private float n3;
	private float m1;
	private float m2;
	private float m3;
	private float x = 0;
    //private float y = 0;
    private float z = 0;
    // Use this for initialization

    // Update is called once per frame
    void Update () {
        Vector3 pos = ARcam.transform.position;
        Vector3 pos2 = ARcam.transform.eulerAngles;

		m1 = Mathf.Tan (pos2.x / 57.3f);
		n1 = (pos.y / m1);

		m2 = n1 * Mathf.Sin (pos2.y / 57.3f);
		n2 = pos.x + m2;

		m3 = n1 * Mathf.Cos (pos2.y / 57.3f);
		n3 = pos.z + m3;
        

        x = x + (n2 - x);
        //y = y + ((pos.y - y) / 4);
        z = z + (n3 - z);
        transform.position = new Vector3(1, 0, 1);
}
}
