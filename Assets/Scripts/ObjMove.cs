using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjMove : MonoBehaviour, OnTouch3D
{	

	public GameObject leftButton;
	public GameObject rightButton;
	public Text messageText;
	public float moveSpeed;
	public bool move;
	public int counter;
	private Vector3 pos;
	private Quaternion rot;

	public void OnTouch()
    {
    	counter++;
    	move = true;
        this.transform.localPosition = pos;
        this.transform.localRotation = rot;
    }

	public void LeftRotate()
	{
		this.transform.Rotate(new Vector3(0, -0.5f, 0));
	}

	public void RightRotate()
	{
		this.transform.Rotate(new Vector3(0, 0.5f, 0));
	}

	public void MoveFront()
	{
		this.transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed);
	}

	void OnCollisionEnter(Collision col){
		if(col.gameObject.name == "Island"){
			Debug.Log("DAME!!!");
			messageText.gameObject.SetActive(true);
        	messageText.text = "Try Again";
			move = false;
		}

		if(col.gameObject.name == "Treasure"){
			messageText.gameObject.SetActive(true);
        	messageText.text = "You found the TREASURE!";
			move = false;
		}
	}

	void Start(){
		move = false;
		pos = this.transform.localPosition;
		rot = this.transform.localRotation;
	}

	void Update(){

		if(move && (counter % 2 == 1)){
			if(leftButton.GetComponent<PointerListener>().Pressed){
				LeftRotate();
			}
		
			else if(rightButton.GetComponent<PointerListener>().Pressed){
				RightRotate();
			}
			MoveFront();
		}
	}
}
