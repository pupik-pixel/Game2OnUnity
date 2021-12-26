using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerScript : MonoBehaviour
{
	public static float speed1;
	public GameObject YouLose;
	float X, Y;
    float speed;
	Animator an;
	int a;
	Text text;
	public GameObject TXT;
	void Start()
	{
		speed = 10f;
		an = GetComponent<Animator>();
		text = TXT.GetComponent<Text>();
		speed1 = 10f;
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject.tag == "astrd")
		{
			an.Play("Death");
			gameObject.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Kinematic;
			gameObject.GetComponent<PlayerScript>().enabled = false;
			Destroy(gameObject,  1.2f);
			YouLose.SetActive(true);
		}
		if (other.gameObject.tag == "star")
		{
			a++;
			other.gameObject.SetActive(false);
			text.text = "Score:" + a;
			speed1 = speed1 + 0.2f*a;
		}
	}


     void Update()
    {
     transform.Translate(new Vector2(X, Y) * speed * Time.deltaTime);
    }
	public void TurnH(float x)
	{ X = x; }
	public void TurnV(float x)
	{ Y = x; }


}
    
   

