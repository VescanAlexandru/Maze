using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour 
{
	public Door door;
	public GameObject Poof;
	public GameObject KeyAnim;
	public AudioClip KeySound;

    //Create a reference to the KeyPoofPrefab and Door

		
	float y=0;
	void Update()
	{
		y += Time.deltaTime * 200;
		transform.rotation = Quaternion.Euler (0, y, 0);


	}

	public void OnKeyClicked()
	{
		GameObject DoorPoof = (GameObject)Instantiate(Poof, transform.position, Quaternion.Euler(270f, 0, 0));
        // Instatiate the KeyPoof Prefab where this key is located
        // Make sure the poof animates vertically
        // Call the Unlock() method on the Door
		door.GetComponent<Door> ().haskey = true;
		// Destroy the key. Check the Unity documentation on how to use Destroy
		Destroy (gameObject);
		AudioSource.PlayClipAtPoint (KeySound, new Vector3 (2, 2, 2));

    }

}
