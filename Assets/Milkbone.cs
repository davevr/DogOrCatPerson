using UnityEngine;
using System.Collections;

public class Milkbone : MonoBehaviour {
	public Texture2D happydogtexture;
	public Texture2D happycattexture;
	public GUITexture dogtexture; 
	public GUITexture cattexture;
	public bool ismoving=false;
	Vector3 savedPosition;
	public GoldenScript gold;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	if (ismoving) {

			Vector3 mouseLoc = Input.mousePosition;
			Rect boneRect = this.guiTexture.GetScreenRect();
			mouseLoc.x = mouseLoc.x - boneRect.width / 2;
			mouseLoc.y = mouseLoc.y - boneRect.height / 2;
			mouseLoc.x = mouseLoc.x / Screen.width;
			mouseLoc.y = mouseLoc.y / Screen.height;
			mouseLoc.z = transform.position.z;
			this.transform.position = mouseLoc;
				}

	
	
	
	
	}

	void OnMouseDown () {
		if (ismoving == false) {
			ismoving = true;
			savedPosition = this.transform.position;
		}
	}

		void OnMouseUp () {
		if (ismoving) {
			ismoving = false;

			Rect boneRect = this.guiTexture.GetScreenRect();
			Rect dogRect = dogtexture.guiTexture.GetScreenRect();
			Rect catRect = cattexture.guiTexture.GetScreenRect();

			if (boneRect.Overlaps(dogRect))
			    {
				DoHappyDog();
			}
			else if (boneRect.Overlaps (catRect))
			         {
				DoHappyCat();
			}
						
			this.transform.position = savedPosition;
		}
	}

void	DoHappyDog(){
		dogtexture.guiTexture.texture = happydogtexture;
		gold.updategold (2);
		}
void	DoHappyCat(){
		cattexture.guiTexture.texture = happycattexture;
		gold.updategold (2);
	}
}








