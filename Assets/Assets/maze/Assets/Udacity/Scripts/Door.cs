using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour 
{
	public bool locked;
	public bool unlocked;
	public bool haskey;
	public AudioClip Door_Locked;
    public AudioClip Door_Opened;
    // Create a boolean value called "locked" that can be checked in Update() 
	void Start (){
		
		locked = true;
		unlocked = false;
		haskey = false;


	}

    void Update() {
		if (haskey == true && unlocked && locked)
		{
			if (transform.position.y <= 25f)
								transform.Translate (0, 25f * Time.deltaTime, 0, Space.World);
			

				
		}
	}
	public void DoorOpenOnClick(){
		if (haskey == true)
		AudioSource.PlayClipAtPoint (Door_Opened, new Vector3 (0, 0, 0));
	

		if (haskey ==false)
			AudioSource.PlayClipAtPoint (Door_Locked, new Vector3 (0, 0, 0));
			

		


		}	

	public void Haskey(){
		if (haskey == true && locked == true)
			unlocked = false;
				locked=true;
		    
			

	}
	public void Unlock(){
		if (haskey == true)
			locked = false;
		   unlocked = true;
				}

				
			
}
