using UnityEngine;
using System.Collections;

public class DieAfterSeconds : MonoBehaviour {
	public AudioClip CoinSound;
	IEnumerator Start () {
        yield return new WaitForSeconds(2.0f);
        Destroy(gameObject);
	}
}
