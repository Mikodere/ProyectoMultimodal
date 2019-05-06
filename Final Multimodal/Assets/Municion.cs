using UnityEngine;
using System.Collections;

public class Municion : MonoBehaviour {

    public float vel;
	Vector3 velocidad;
	public float ToLife=2; 

	// Update is called once per frame
	void Update () {
		Debug.Log ("Velocidad " + velocidad.x + " " + velocidad.y + " " + velocidad.z);
		transform.position = transform.position + velocidad*Time.deltaTime;
	}
	public void Lanzar(Transform t)
	{
		transform.position = t.position;
		velocidad= new Vector3(0,0,-1 * vel);
		GameObject.Destroy(gameObject,ToLife);

	}

}
