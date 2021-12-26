using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
	public void Reboot()
	{
		Application.LoadLevel(Application.loadedLevel);
	}
}
