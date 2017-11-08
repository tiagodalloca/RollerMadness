using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System;

public class Treasure : MonoBehaviour {

	public int ultimo_level = 3;
	public int proximo_nivel = 5;
	public int value = 10;
	public GameObject explosionPrefab;

	void OnTriggerEnter (Collider other)
	{
		if (other.gameObject.tag == "Player") {
			if (GameManager.gm!=null)
			{
				// tell the game manager to Collect
				GameManager.gm.Collect (value);
				// Debug.Log(GameManager.gm.score);
				// if (GameManager.gm.score >= proximo_nivel){

				// 	var num  = Convert.ToInt32(SceneManager.GetActiveScene().name.Substring(4,2));
				// 	num++;

				// 	Debug.Log(Convert.ToString(ultimo_level) + "," + Convert.ToString(num));

				// 	if (num <= ultimo_level)
				// 		Application.LoadLevel("cena0" + num);
						
				// }
			}
			
			// explode if specified
			if (explosionPrefab != null) {
				Instantiate (explosionPrefab, transform.position, Quaternion.identity);
			}
			
			// destroy after collection
			Destroy (gameObject);
		}
	}
}
