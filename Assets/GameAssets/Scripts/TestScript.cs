using UnityEngine;
using System.Collections;

public class TestScript : MonoBehaviour
{

	// Use this for initialization
	void Awake ()
	{
		Debug.Log("Am awake");
	}

	void Start()
	{
		Debug.Log("Am starting");
	}
	// Update is called once per frame
	void Update ()
	{
		Debug.Log( "Update realTime: "+Time.deltaTime);
	
	}

	void FixedUpdate()
	{
		Debug.Log( "FixedUpdate realTime: "+Time.deltaTime);
	}
}
