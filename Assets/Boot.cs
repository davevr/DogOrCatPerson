using UnityEngine;
using System.Collections;

public class Boot : MonoBehaviour {
	public Texture2D saddogtexture;
	public Texture2D sadcattexture;
	public GUITexture dogtexture; 
	public GUITexture cattexture;
	public bool ismoving=false;
	public GoldenScript gold;

	Vector3 savedPosition;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (ismoving) {
			
			Vector3 mouseLoc = Input.mousePosition;
			Rect bootRect = this.guiTexture.GetScreenRect();
			mouseLoc.x = mouseLoc.x - bootRect.width / 2;
			mouseLoc.y = mouseLoc.y - bootRect.height / 2;
			mouseLoc.x = mouseLoc.x / Screen.width;
			mouseLoc.y = mouseLoc.y / Screen.height;
			mouseLoc.z = transform.position.z;
			this.transform.position = mouseLoc;
		}
	}

	
	
	void OnMouseDown () {
		ismoving = true;
		savedPosition = this.transform.position;
	}
	
	void OnMouseUp () {
		if (ismoving) {
			ismoving = false;
			
			Rect bootRect = this.guiTexture.GetScreenRect();
			Rect dogRect = dogtexture.guiTexture.GetScreenRect();
			Rect catRect = cattexture.guiTexture.GetScreenRect();
			
			if (bootRect.Overlaps(dogRect))
			{
				DoSadDog();
			}
			else if (bootRect.Overlaps (catRect))
			{
				DoSadCat();
			}
			
			
			this.transform.position = savedPosition;
		}
		
	}
	
	void	DoSadDog(){
		dogtexture.guiTexture.texture = saddogtexture;
		gold.updategold (1);

	}
	void	DoSadCat(){
		cattexture.guiTexture.texture = sadcattexture;
		gold.updategold (1);
	}
}































