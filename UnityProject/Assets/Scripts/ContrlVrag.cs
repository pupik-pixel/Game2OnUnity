using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContrlVrag : MonoBehaviour
{
	public GameObject obj;
	public GameObject obj1;

	// Start is called before the first frame update
	void Start()
	{
		StartCoroutine(N());
		StartCoroutine(N1());
	}

	// Update is called once per frame


	IEnumerator N()
	{
		for (; ; )
		{
			yield return new WaitForSeconds(1f);
			Instantiate(obj, new Vector3(9.9f, Random.Range(-3.4f, 3.4f), 17f), Quaternion.identity);
		}
	}

	IEnumerator N1()
	{
		for (; ; )
		{
			yield return new WaitForSeconds(2f);
			Instantiate(obj1, new Vector3(9.9f, Random.Range(-3.4f, 3.4f), 17f), Quaternion.identity);
		}
	}

	void Update()
	{
		if (Input.GetKey(KeyCode.Escape)) Application.Quit();
	}
}
