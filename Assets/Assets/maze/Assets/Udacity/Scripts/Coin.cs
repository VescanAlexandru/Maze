using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour 


{
	public AudioClip CoinSound;
	public GameObject Poof;
	float y=0;

	void Update(){
		y += Time.deltaTime * 200;
		transform.rotation = Quaternion.Euler (0, y, 0);
	}
		public void OnCoinClicked() {
					
		GameObject poof = (GameObject)Instantiate(Poof, transform.position, Quaternion.Euler(-90f, 0, 0));
	 // Instantiate the CoinPoof Prefab where this coin is located
        // Make sure the poof animates vertically
        // Destroy this coin. Check the Unity documentation on how to use Destroy
		Destroy (gameObject);
		AudioSource.PlayClipAtPoint (CoinSound, new Vector3 (2, 2, 2));
    }

}