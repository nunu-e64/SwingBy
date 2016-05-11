using UnityEngine;
using System.Collections;

public class BackGroundScroll : MonoBehaviour {

	public float speed = 0.01f;			// スクロールするスピード
	private GameObject camera;
	private Vector3 offset;

	void Start() {
		camera = GameObject.FindGameObjectWithTag ("MainCamera");
		offset = camera.transform.position;
	}
	// Update is called once per frame
	void Update () {
		offset = camera.transform.position;
		offset.Scale (new Vector3 (1.0f / transform.localScale.x, 1.0f / transform.localScale.y, 1.0f / transform.localScale.z));
		GetComponent<Renderer>().sharedMaterial.SetTextureOffset ("_MainTex", offset);	// マテリアルにオフセットを設定する.
		transform.position = new Vector3(camera.transform.position.x, camera.transform.position.y, 1);
	}
}
