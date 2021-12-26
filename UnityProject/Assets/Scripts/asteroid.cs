using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asteroid : MonoBehaviour
{
    // Start is called before the first frame update
	void Start()
	{
			Destroy(gameObject, 5f);
		
	}

    // Update is called once per frame
    void Update()
    {
		transform.Translate(new Vector2(-1f, 0) * Time.deltaTime*PlayerScript.speed1);
    }
}
