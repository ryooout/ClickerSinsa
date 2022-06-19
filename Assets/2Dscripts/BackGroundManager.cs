using UnityEngine;
using System.Collections;

public class BackGroundManager : MonoBehaviour
{
	void Update()
	{
		Scroll();
	}
	public void Scroll()
    {
		transform.Translate(0, 0.05f, 0);
		if (transform.position.y > 4.0f) 
		{
			transform.position = new Vector3(0, -4.0f, 0);
		}
	}
}
