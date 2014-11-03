using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CoinsScoreManager : MonoBehaviour {

	public static int coinsScore;

	Text text;

	void Awake ()
	{
		text = GetComponent <Text> ();
		coinsScore = 0;
	}
	
	
	void Update ()
	{
		text.text = "" + coinsScore;
	}
}
