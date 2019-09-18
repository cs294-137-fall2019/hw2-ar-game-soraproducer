using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class RightRotate : MonoBehaviour
{
    private bool _rotate;
    public GameObject boat;
 
	void Update()
	{
		if(_rotate)
		{
			boat.transform.Rotate(new Vector3(0, 10, 0));
		}
	}

	public void OnPress()
	{
		_rotate = true;
	}

	public void OnRelease()
	{
		_rotate = false;
	}
}
