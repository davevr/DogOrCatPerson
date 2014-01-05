using UnityEngine;
using System.Collections;

public class GoldenScript : MonoBehaviour {
	public int currentgold = 0;


public void updategold(int newgold){
		currentgold = currentgold + newgold;
		this.guiText.text = currentgold.ToString () + " Gold";
	
	}

	
}
