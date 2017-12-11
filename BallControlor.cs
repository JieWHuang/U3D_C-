using UnityEngine;
using System.Collections;

public class BallControl : MonoBehaviour{
	public stactic int s = 0;
	void Update(){
		if(Input.GatKey(KeyCode.W))
		{
			this.gameobject.transfrom.Translate(0f,0f,0.1f);
		}
		else if(Input.GatKey(KeyCode.S))
		{
			this.gameobject.transfrom.Translate(0f,0f,-0.1f);
		}
		else if(Input.GatKey(KeyCode.A))
		{
			this.gameobject.transfrom.Translate(-0.1f,0f,0f);
		}
		else if(Input.GatKey(KeyCode.D))
		{
			this.gameobject.transfrom.Translate(0.1f,0f,0f);
		}
	}
}